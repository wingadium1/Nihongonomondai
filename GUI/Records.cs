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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizletDataSet.RECORDS' table. You can move, or remove it, as needed.
            this.rECORDSTableAdapter.Fill(this.quizletDataSet.RECORDS);
            
        }
    }
}
