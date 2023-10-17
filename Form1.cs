using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentsDataSet.dbstudents' table. You can move, or remove it, as needed.
            this.dbstudentsTableAdapter.Fill(this.dbStudentsDataSet.dbstudents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dbstudentsBindingSource.MoveNext();
        }
    }
}
