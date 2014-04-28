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
    public partial class NewUser : Form
    {
        public ScoreTrendDataClassesDataContext context = new ScoreTrendDataClassesDataContext();   //make connection with database

        public NewUser()
        {
            InitializeComponent();
            
        }
        

        private void btnCancel_Click(object sender, EventArgs e)    //exit button on application
        {
            if (MessageBox.Show("Would you like to Exit ScoreTrend?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            

            if (txtFirstName.Text == "")    //validating that information has been entered into the text boxes.
            {
                MessageBox.Show("Please enter first name");
                this.txtFirstName.Focus();
                return;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter last name");
                this.txtLastName.Focus();
                return;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter user name");
                this.txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
                this.txtPassword.Focus();
                return;
            }

            Boolean approved = false;   //bool for approval of validation
            u = txtUsername.Text;
            p = txtPassword.Text;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;  
                      

            approved = UserValidate.validate(u,p);  //send to u and p to UserValidate to validate that it is in the correct format

            try
                {
                    if (approved == true)   //once approved, the username is queryed against the database to see if there is another user with the same name
                    {
                        var queryIsUsernameTaken = from users in context.users where users.username == u select u;
                        string usernameIsTaken = Convert.ToString(queryIsUsernameTaken);                   
      
                        if (!usernameIsTaken.Equals(u,StringComparison.OrdinalIgnoreCase))//if statement condition that name is not taken
                            {
                                this.addNewUserInformation();   //use the addNewUserInformation method  
                                MessageBox.Show("Your information has been entered in the database, you will be re-routed to the login screen.","ScoreTrend");
                                Login login = new Login();      //create new login object and view login GUI
                                login.Show();
                                this.Hide();

                                                               
                            }
                        else
                        {          //Message box to tell the username has been used and if they would like to go back to the login screen
                            if (MessageBox.Show(u + " is already been used, please select another username. Would you like to go back to login screen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                                {
                                    Login login = new Login();
                                    login.Show();
                                    this.Hide();
                                }
                            
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtUsername.Focus();                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usernames and Passwords must be a length of 8 to 20 aplhanumeric characters. The password cannot start with a digit, underscore or special character and must contain at least one digit.");
                        txtUsername.Clear();
                    }
                }
            catch (Exception ex)
                {
                    MessageBox.Show("Cannot communicate with database. Application will now close." + ex.Message);
                    Application.Exit();
                }
            
        }

        public void addNewUserInformation()
        {
            using (ScoreTrendDataClassesDataContext dbNewUser = new ScoreTrendDataClassesDataContext())
            {
                try
                {
                    user newUser = new user();  //create new user table row with this object

                    newUser.username = u;   //set new username as u;
                    newUser.password = p;   //set new password as p;
                    newUser.teamid = intTeamIdSelected;     //send the rest of the information to the user table
                    newUser.leagueid = intLeagueIdSelected;
                    newUser.firstname = firstname;
                    newUser.lastname = lastname;

                    if (radYesAuth.Checked) //if authorized scorekeeper
                    {
                        newUser.authorized = 1;
                    }
                    else
                    {
                        newUser.authorized = 0;
                    }

                    dbNewUser.users.InsertOnSubmit(newUser);
                    dbNewUser.SubmitChanges();  //submit changes

                    

                    if (radYesIAmAPlayer.Checked)   //if user is a player
                    {
                        player newPlayer = new player();    //create new player table row with this object

                        newPlayer.teamid = intTeamIdSelected;   //insert new player information
                        newPlayer.firstname = firstname;
                        newPlayer.lastname = lastname;

                        dbNewUser.players.InsertOnSubmit(newPlayer);    
                        dbNewUser.SubmitChanges();  //submit changes

                        var newPlayerIdGiven1 = from players in context.players where players.firstname == firstname && players.lastname == lastname select players;
                        

                        //update player id for new player from the users table player id
                        var newPlayerIdGiven2 = (from players in context.players where players.firstname == firstname && players.lastname == lastname select players).Single();
                        newPlayerIdGiven2.playerid = 3012;

                        context.SubmitChanges();                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot communicate with database. Application will now close.","ScoreTrend" + ex);
                    Application.Exit();
                }
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {            
            this.leagueBindingSource.DataSource = context.leagues;            
        }

        private void btnBack_Click(object sender, EventArgs e)  //go back to the login screen
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private object leagueSelected;
        private int intLeagueIdSelected;
        private object TeamSelected;
        private int intTeamIdSelected;
        public string u;
        public string p;
        public string firstname;
        public string lastname;
        private int intNewPlayerId;
        private string strNewPlayerId;

        private void cboPickYourLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            leagueSelected = cboPickYourLeague.SelectedValue;     //store the selected value in combobox as object
            intLeagueIdSelected = Convert.ToInt32(leagueSelected);  //convert this object that has returned the leagueid integer into an integer

            var querySelectedLeague = from teams in context.teams where teams.leagueid == intLeagueIdSelected select teams;
            
            this.teamBindingSource.DataSource = querySelectedLeague;   //put the query into the team combobox

        }

        private void cboPickYourTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TeamSelected = cboPickYourTeam.SelectedValue;   //team selected combobox value
            intTeamIdSelected = Convert.ToInt32(TeamSelected);
                       
        }
    }
}
