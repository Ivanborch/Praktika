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
    public partial class TeamDetail : Form
    {
        public int IdTeam = 0;
        Team team = new Team();

        public TeamDetail()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeamDetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TeamsMain1.teams.Length; i++)
            {
                if (TeamsMain1.teams[i].Teamid == IdTeam)
                    this.team = TeamsMain1.teams[i];
            }
            label4.Text = "TeamName | " + team.Name;

            for (int i = 0; i < Form1.players.Length; i++)
            { if (Form1.players[i].Teamid == this.IdTeam)
                
                    dataGridView1.Rows.Add(Form1.players[i].PlayerId, Form1.players[i].Name, Form1.players[i].positionalId, Form1.players[i].dateBirth);
                
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
