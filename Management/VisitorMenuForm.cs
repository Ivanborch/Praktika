using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class VisitorMenuForm : Form
    {
        public VisitorMenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            VisitorMenuForm VisitorForm = new VisitorMenuForm();
            VisitorForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeamsMain1 teamsMain1 = new TeamsMain1();
            teamsMain1.Show();
        }
    }
}
