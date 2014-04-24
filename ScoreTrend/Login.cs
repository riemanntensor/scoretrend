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
        string username = "";
        string password = "";
        public Login()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean approved = false;
            username = txtUsername.Text;
            password = txtPassword.Text;
            
            approved =  UserValidate.validate(password);

            if (approved == true)
                {                    
                    Dashboard session = new Dashboard();
                    session.Show();
                    this.Hide();
                }
            else
                {
                    lblErrorLogin.Visible = true;
                    lblErrorLogin.Text = "***You cannot use spaces or special characters***";
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                       
            
        }

        private void lnkStartNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Exit ScoreTrend?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        
        }

        private void exitScoreTrendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Exit ScoreTrend?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }
    }
}
