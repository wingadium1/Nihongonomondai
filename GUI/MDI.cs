using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void learnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Learn newFormLearn = new Learn();
            newFormLearn.MdiParent = this;
            newFormLearn.Show();
        }

        private void learnCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LearnCard newFormLearn = new LearnCard();
            newFormLearn.MdiParent = this;
            newFormLearn.Show();
        }

        private void editCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCard newFormEdit = new EditCard();
            newFormEdit.MdiParent = this;
            newFormEdit.Show();
        }

        private void smallTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test newTest = new Test();
            newTest.MdiParent = this;
            newTest.Show();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Records newRecord = new Records();
            newRecord.MdiParent = this;
            newRecord.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newAbt = new About();
            newAbt.MdiParent = this;
            newAbt.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
