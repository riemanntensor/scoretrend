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
        private string username = "";
        private string password = "";
       

        public Login()
        {
            InitializeComponent();
        }

        public string CurrentUsername
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public override string ToString()
        {
            return username;
        }

        
        private void btnLogin_Click(object sender, EventArgs e) //login button takes username and password
        {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter user name");
                this.txtUsername.Focus();
                return;
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
                this.txtPassword.Focus();
                return;
            }
                else
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                }   

            try
            {
                var queryUserName = from users in context.users where users.username == username select username;
                isUserNameCorrect = Convert.ToString(queryUserName);

                var queryPassword = from users in context.users where users.password == password select password;
                isUserPasswordCorrect = Convert.ToString(queryPassword);

                if (isUserNameCorrect.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    if (isUserPasswordCorrect.Equals(password, StringComparison.Ordinal))
                    {
                        this.CurrentUsername = username;
                        Dashboard session = new Dashboard();
                        session.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct password");
                        this.txtPassword.Focus();
                        return;
                    }
                }
                else
                {
                    this.CurrentUsername = username;
                    Dashboard session = new Dashboard();
                    session.Show();
                    this.Hide();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot communicate with database. Application will now close." + ex.Message);
                Application.Exit();
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
        private string isUserNameCorrect;
        private string isUserPasswordCorrect;
        public ScoreTrendDataClassesDataContext context = new ScoreTrendDataClassesDataContext();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutScoreTrendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ScoreTrend is a ScoreCard Database Program designed to store player statistics");
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
