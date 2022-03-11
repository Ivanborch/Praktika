using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //imgList
        Country[] countries = new Country[5];


        String[] imglist = new String[]
            {"0.jpg","1.jpeg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg"};
        int index = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("../../../Pictures/" + imglist[0]);
            pictureBox2.Load("../../../Pictures/" + imglist[1]);
            pictureBox3.Load("../../../Pictures/" + imglist[2]);
            Country country = new Country();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;

            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form();
            adminForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            index = index + 1;
            if (index+3 > imglist.Length) index = 0;
            pictureBox1.Load("../../../Pictures/" + imglist[index+0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index+1]);
            pictureBox3.Load("../../../Pictures/" + imglist[index+2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index-3 < 0) index = imglist.Length-3;
            pictureBox1.Load("../../../Pictures/" + imglist[index+0]);
            pictureBox2.Load("../../../Pictures/" + imglist[index+1]);
            pictureBox3.Load("../../../Pictures/" + imglist[index+2]);
        }
    }
}
