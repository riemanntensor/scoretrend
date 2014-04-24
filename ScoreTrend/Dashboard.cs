using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTrend
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDashExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Exit ScoreTrend?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.leagueBindingSource.DataSource = context.leagues;
            
        }

        private void cboLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var fillTeamsByLeague = from c in dbo. where c.leagueid = 1001 select c;
            this.teamBindingSource.DataSource = context.teams;
            cboTeam.Visible = true;
            this.Refresh();
        }
  

        //user selects a player from the given options after selecting league and team
        private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public ScoreTrendDataClassesDataContext context = new ScoreTrendDataClassesDataContext();

        
    }
}
