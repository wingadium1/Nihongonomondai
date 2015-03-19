using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Test : Form
    {

        List<QuestionGrammar> listquest = new List<QuestionGrammar>();
        QuestionGrammar current = new QuestionGrammar();
        int[] choice;
        int timeLeft;
        public Test()
        {
            InitializeComponent();
            Loading();
            Start();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void Loading()
        {
            listquest = LoadFromLibrary.RandomTest();
            choice = new int[listquest.Count];

            for (int i = 0; i < listquest.Count; i++)
            {
                choice[i] = 0;
            }


            foreach (var q in listquest)
            {

                listBox1.Items.Add(string.Format("Question {0}", listquest.IndexOf(q)+1));
            }

            listBox1.SelectedIndex = 0;
        }

        private void Start()
        {
            if (MessageBox.Show("Start the test ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                StartTheQuiz();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            if (id < 0)
            {
                return;
            }
            current = listquest[id];
            labelQuestionNo.Text = String.Format("{0}/{1}", id + 1, listquest.Count);
            labelQuestion.Text = current.question;
            radioButton1.Text = current.choice[0];
            radioButton2.Text = current.choice[1];
            radioButton3.Text = current.choice[2];
            radioButton4.Text = current.choice[3];

            switch(choice[id])
            {
                case 0: radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1: radioButton1.Checked = true;
                    break;
                case 2: radioButton2.Checked = true;
                    break;
                case 3: radioButton3.Checked = true;
                    break;
                case 4: radioButton4.Checked = true;
                    break;
            }
               
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton2.Checked) radioButton2.Checked = false;
                if (radioButton3.Checked) radioButton3.Checked = false;
                if (radioButton4.Checked) radioButton4.Checked = false;
                choice[listBox1.SelectedIndex] = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (radioButton2.Checked) radioButton2.Checked = false;
                if (radioButton1.Checked) radioButton1.Checked = false;
                if (radioButton4.Checked) radioButton4.Checked = false;
                choice[listBox1.SelectedIndex] = 3;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (radioButton1.Checked) radioButton1.Checked = false;
                if (radioButton3.Checked) radioButton3.Checked = false;
                if (radioButton4.Checked) radioButton4.Checked = false;
                choice[listBox1.SelectedIndex] = 2;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (radioButton2.Checked) radioButton2.Checked = false;
                if (radioButton3.Checked) radioButton3.Checked = false;
                if (radioButton1.Checked) radioButton1.Checked = false;
                choice[listBox1.SelectedIndex] = 4;
            }
        }

        private void StartTheQuiz()
        {
            timeLeft = 2400;
            timeLabel.Text = "40:00";
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left 
                // by updating the Time Left label.
                timeLeft -= 1;
                timeLabel.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                finishtTest();
               // MessageBox.Show("Time's up");
                this.Close();
            }
        }

        private void finishtTest()
        {
            timer1.Stop();
            float count = 0;
            foreach (var x in listquest)
            {
                if (x.flagTrue == choice[listquest.IndexOf(x)])
                    count+=1;
            }

            string conStr = "Server=localhost; Database=quizlet; Integrated Security = true";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            //Insert topic details into DB.Topic table
            //parameterized query
            string sql = "INSERT INTO RECORDS(timeleft, timetest,mark) VALUES(@timeleft,@timetest,@mark)";

            SqlCommand cmd = new SqlCommand(sql, con);
            //declare parameters
            cmd.Parameters.Add("timeleft", SqlDbType.Int);
            cmd.Parameters.Add("timetest", SqlDbType.Int);
            cmd.Parameters.Add("mark", SqlDbType.Float);
            //set params value
            cmd.Parameters["timeleft"].Value = timeLeft;
            cmd.Parameters["timetest"].Value = 2400;
            cmd.Parameters["mark"].Value = 10*count/listquest.Count;
            //excute
            Console.Write(cmd.CommandText);
            int ret = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("YOU HAVE "+ count +" TRUE ANSWERS");
            
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (checkBoxFinish.Checked)
            {
                finishtTest();
                //MessageBox.Show("FINISHED TEST");
                this.Close();
                return;
            }
            else
            {
                return;
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            if (id == 0) id = listquest.Count - 1;
            else id -= 1;
            listBox1.SelectedIndex = id;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            if (id == listquest.Count - 1) id = 0;
            else id += 1;
            listBox1.SelectedIndex = id;
        }

    }
}
