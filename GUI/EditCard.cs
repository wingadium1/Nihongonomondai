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
    public partial class EditCard : Form
    {

        List<Lesson> listLesson = new List<Lesson>();
        List<Word> listWord = new List<Word>();
        Word current = new Word();
        bool n = false;
        public EditCard()
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
            try
            {
                listBox1.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                listBox1.SelectedIndex = -1;
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxMeaning.Text = "";
            textBoxNihon.Text = "";
            textBoxRoman.Text = "";
            textBoxMeaning.Enabled = false;
            textBoxNihon.Enabled = false;
            textBoxRoman.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;


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

            try
            {
                listBox2.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                listBox2.SelectedIndex = -1;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (n)
            {
                listBox2.Items.Remove("NULL");
                listWord.RemoveAt(listWord.Count - 1);
                n = false;
            }
            


            int id = listBox2.SelectedIndex;
            if (id < 0)
            {
                return;
            }
            current = listWord[id];


            textBoxMeaning.Enabled = true;
            textBoxNihon.Enabled = true;
            textBoxRoman.Enabled = true;
            buttonDelete.Enabled = true;
            textBoxMeaning.Text = current.meaning;
            textBoxNihon.Text = current.hiragana;
            textBoxRoman.Text = current.romaji;
            buttonSave.Enabled = false;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            
            listWord.Add(new Word());
            listBox2.Items.Add("NULL");
            listBox2.SelectedIndex = listWord.Count - 1;
            n = true;
        }


        private void textBoxRoman_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRoman.Text.CompareTo(current.romaji) != 0) buttonSave.Enabled = true;
            else buttonSave.Enabled = false;
        }

        private void textBoxNihon_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNihon.Text.CompareTo(current.hiragana) != 0) buttonSave.Enabled = true;
            else buttonSave.Enabled = false;
        }

        private void textBoxMeaning_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMeaning.Text.CompareTo(current.meaning) != 0) buttonSave.Enabled = true;
            else buttonSave.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listWord.Remove(current);
            int id = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(id);
            listBox2.SelectedIndex = -1;
            textBoxMeaning.Text = "";
            textBoxNihon.Text = "";
            textBoxRoman.Text = "";
            textBoxMeaning.Enabled = false;
            textBoxNihon.Enabled = false;
            textBoxRoman.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            n = false;
            current.hiragana = textBoxNihon.Text;
            current.romaji = textBoxRoman.Text;
            current.meaning = textBoxMeaning.Text;
            int id = listBox2.SelectedIndex;
            listBox2.Items[id] = string.Format("{0}", current.meaning);
            buttonSave.Enabled = false;

        }

        private void EditCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void buttonSavetofile_Click(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            if (id < 0)
            {
                return;
            }
            Lesson currentLesson = listLesson[id];
            LoadFromLibrary.saveWordToLesson(currentLesson, listWord);
        }




    }
}
