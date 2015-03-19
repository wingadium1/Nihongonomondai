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
    public partial class LearnCard : Form
    {

        List<Lesson> listLesson = new List<Lesson>();
        List<Word> listWord = new List<Word>();
        Word current = new Word();
        public LearnCard()
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

            listBox1.SelectedIndex = 0;
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


            listBox2.Items.Clear();
            foreach (var q in listWord)
            {

                listBox2.Items.Add(string.Format("{0}", q.meaning));
            }

            listBox2.SelectedIndex = 0;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBox2.SelectedIndex;
            if (id < 0)
            {
                return;
            }
            current = listWord[id];
            label2.Text = current.meaning;
            button1.Enabled = true;
            label3.Text = "";

        }

        private void LearnCard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = current.hiragana;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int id = listBox2.SelectedIndex;
            if (id == 0) id = listWord.Count - 1;
            else id -= 1;
            listBox2.SelectedIndex = id;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int id = listBox2.SelectedIndex;
            if (id == listWord.Count-1) id = 0;
            else id += 1;
            listBox2.SelectedIndex = id;
        }

    }
}
