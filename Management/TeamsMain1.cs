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
    public partial class TeamsMain1 : Form
    {
        String[] imgList = new String[]
        {
            "1.jpg", "2.jpg"
        };
        int index = 0;
        public static Team[] teams = new Team[15];

        String[] imgLists = new String[]
           {"1.jpeg", "2.jpg", "3.jpg", "1.jpeg", "2.jpg"};
        int indexs = 0;
        public TeamsMain1()
        {
            InitializeComponent();

            Team team = new Team();

            teams[0] = new Team();
            teams[0].Set(1, "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].Set(2, "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].Set(3, "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].Set(4, "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].Set(5, "Charlotte Hornets", "CHA", "5.jpg");

            teams[5] = new Team();
            teams[5].Set(6, "Detroit Pistons", "DET", "6.jpg");

            teams[6] = new Team();
            teams[6].Set(7, "Indiana Pacers", "IND", "7.jpg");

            teams[7] = new Team();
            teams[7].Set(8, "Cleveland Cavaliers", "CLE", "8.jpg");

            teams[8] = new Team();
            teams[8].Set(9, "Chicago Bulls", "CHI", "9.jpg");

            teams[9] = new Team();
            teams[9].Set(10, "Milwaukee Bucks", "MIL", "10.jpg");

            teams[10] = new Team();
            teams[10].Set(11, "Boston Celtics", "BOS", "11.jpg");

            teams[11] = new Team();
            teams[11].Set(12, "Philadelphia 76ers", "PHI", "12.jpg");

            teams[12] = new Team();
            teams[12].Set(13, "New York Knicks", "NY", "13.jpg");

            teams[13] = new Team();
            teams[13].Set(14, "Brooklyn Nets", "BKN", "14.jpg");

            teams[14] = new Team();
            teams[14].Set(15, "Toronto Raptors", "TOR", "15.jpg");


            //label10.Text = teams[0].Name;
            /*   label11.Text = teams[1].Name;
               label12.Text = teams[2].Name;
               label13.Text = teams[3].Name;
               label14.Text = teams[4].Name;*/

            for (int i = 0; i < 5; i++)
            {
               
                    
                        tabPage1.Controls["panel" + 1].Controls["label" + 1 + i].Text = teams[0 + i].Name;
                        tabPage1.Controls["panel" + 2].Controls["label" + 2 + i].Text = teams[5 + i].Name;
                        tabPage1.Controls["panel" + 3].Controls["label" + 3 + i].Text = teams[10 + i].Name;

                    
                
            }

           /* for (int j = 0; j < 3; j++)
            {
                for (int i = 4; i < 7; i++)
                {
                    tabPage1.Controls["panel" + 1].Controls["pictureBox" +i].BackgroundImage = ("../../Pictures/" + imgLists[0]);
                }
            }*/
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 1;
            TDform.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            //TDform.IdTeam = 2;
            TDform.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TeamsMain1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 3;
            TDform.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 4;
            TDform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 5;
            TDform.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 6;
            TDform.Show();
        }


        private void label22_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 8;
            TDform.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 9;
            TDform.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 10;
            TDform.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 7;
            TDform.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 12;
            TDform.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 11;
            TDform.Show();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 13;
            TDform.Show();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 14;
            TDform.Show();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            TeamDetail TDform = new TeamDetail();
            TDform.IdTeam = 15;
            TDform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           VisitorMenuForm visitorMenuForm = new VisitorMenuForm();
            visitorMenuForm.Show();
        }
    }
}
