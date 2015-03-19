using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace GUI
{
    public partial class Learn : Form
    {
        List<Lesson> listLesson = new List<Lesson>();
        List<Word> listWord = new List<Word>();
        List<Word> remainingWord = new List<Word>();
        Word current = new Word();
        int remaining = 0;
        int incorrect = 0;
        int correct = 0;
        bool japs = false;

        public Learn()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            listLesson.Clear();
            listLesson = LoadFromLibrary.getLessonList();
            foreach (var q in listLesson)
            {

                listBox1.Items.Add(string.Format("[{0}]", q.name));
            }

            listBox1.SelectedIndex = listLesson.Count - 1;


            //set disable button and text;

            //GiveupBtn.Enabled = false;
            textBoxAns.Enabled = false;
            buttonAnswer.Enabled = false;
            checkBoxJap.Enabled = false;
            buttonStartOver.Enabled = false;
            buttonOverride.Enabled = false;
            labelCorrect.Text = "";
            labelNotCorrect.Text = "";

            labelQuest.Text = "";
            labelTrueAns.Text = "";
            labelYourAns.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            if (id < 0)
            {
                return;
            }

            Lesson ls = listLesson[id];
            listWord = LoadFromLibrary.getWordFromLesson(ls);
            remainingWord = listWord;
            remaining = remainingWord.Count;
            wordRemainingLabel.Text = "" + remaining;

            roundLabel.Text = "1";
            correct = 0;
            incorrect = 0;
            labelCorrect.Text = "" + correct;
            checkBoxJap.Enabled = true;
            labelNotCorrect.Text = "" + incorrect;

            current = remainingWord[0];
            if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
            else labelQuest.Text = current.meaning;
            //set enable
            //GiveupBtn.Enabled = true;
            textBoxAns.Enabled = true;
            buttonAnswer.Enabled = true;
            buttonStartOver.Enabled = true;
            textBoxAns.Text = "";
            buttonOverride.Enabled = false;
            labelTrueAns.Text = "";
  
        }

        private void checkBoxJap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
            else labelQuest.Text = current.meaning;
        }

        private void buttonStartOver_Click(object sender, EventArgs e)
        {
            remainingWord = listWord;
            remaining = remainingWord.Count;
            wordRemainingLabel.Text = "" + remaining;

            roundLabel.Text = "1";
            correct = 0;
            incorrect = 0;
            labelCorrect.Text = "" + correct;
            checkBoxJap.Enabled = true;
            labelNotCorrect.Text = "" + incorrect;

            current = remainingWord[0];
            if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
            else labelQuest.Text = current.meaning;
            //set enable
          //  GiveupBtn.Enabled = true;
            textBoxAns.Enabled = true;
            buttonAnswer.Enabled = true;
            buttonStartOver.Enabled = true;
            textBoxAns.Text = "";
            buttonOverride.Enabled = false;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (remaining == 0)
            {
                var enter = System.Environment.NewLine;
                MessageBox.Show("END ROUND " + roundLabel.Text + enter + "Correct :" + correct + enter
                    + "Incorrect :" + incorrect + enter);
                if (remainingWord.Count == 0) return;

                roundLabel.Text = "" + (int.Parse(roundLabel.Text) + 1);
                remaining = remainingWord.Count;
                wordRemainingLabel.Text = "" + remaining;

                correct = 0;
                incorrect = 0;
                labelCorrect.Text = "" + correct;
                labelNotCorrect.Text = "" + incorrect;

            }
            if (!buttonOverride.Enabled)
            {
                string ans = textBoxAns.Text;
                string trueans = (checkBoxJap.Checked) ? current.meaning : current.hiragana;
                remaining -= 1;
                wordRemainingLabel.Text = "" + remaining;

                if (trueans.CompareTo(ans) == 0)
                {
                    correct += 1;
                    labelCorrect.Text = "" + correct;
                    remainingWord.RemoveAt(0);
                    current = remainingWord[0];
                    if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
                    else labelQuest.Text = current.meaning;
                    textBoxAns.Text = "";
                }

                else
                {
                    labelTrueAns.Text = "Correct: " + trueans;
                    buttonOverride.Enabled = true;
                    incorrect += 1;
                    labelNotCorrect.Text = "" + incorrect;
                }

            }
            else
            {
                string ans = textBoxAns.Text;
                string trueans = (checkBoxJap.Checked) ? current.meaning : current.hiragana;
                if (trueans.CompareTo(ans) == 0)
                {
                    
                    remainingWord.Add(remainingWord[0]);
                    remainingWord.RemoveAt(0);
                    current = remainingWord[0];
                    if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
                    else labelQuest.Text = current.meaning;
                    textBoxAns.Text = "";
                    labelTrueAns.Text = "";
                    buttonOverride.Enabled = false;
                }
            }
            
            
        }

        private void buttonOverride_Click(object sender, EventArgs e)
        {
            correct += 1;
            labelCorrect.Text = "" + correct;
            remainingWord.RemoveAt(0);
            current = remainingWord[0];
            if (checkBoxJap.Checked == true) labelQuest.Text = current.hiragana;
            else labelQuest.Text = current.meaning;
            textBoxAns.Text = "";
            incorrect -= 1;
            labelNotCorrect.Text = "" + incorrect;
            labelTrueAns.Text = "";
            buttonOverride.Enabled = false;
        }
    }
     
}
