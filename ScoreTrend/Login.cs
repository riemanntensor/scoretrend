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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard session = new Dashboard();
            session.Show();
            this.Hide();
        }

        private void lnkStartNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
