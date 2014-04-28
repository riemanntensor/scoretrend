namespace ScoreTrend
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleDesc = new System.Windows.Forms.Label();
            this.lblSelectLeague = new System.Windows.Forms.Label();
            this.lblTeamLabel = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.cboPlayer = new System.Windows.Forms.ComboBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.statisticBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDashExit = new System.Windows.Forms.Button();
            this.cboLeagues = new System.Windows.Forms.ComboBox();
            this.leagueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnEnterGameInfo = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStrikeouts = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStrikeOutData = new System.Windows.Forms.Label();
            this.statisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lblRunsScored = new System.Windows.Forms.Label();
            this.lblRunsScoredData = new System.Windows.Forms.Label();
            this.lblTeamData = new System.Windows.Forms.Label();
            this.lblBattingAvg = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblBatAvgData = new System.Windows.Forms.Label();
            this.lblHitsData = new System.Windows.Forms.Label();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(198, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ScoreTrend";
            // 
            // lblTitleDesc
            // 
            this.lblTitleDesc.AutoSize = true;
            this.lblTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDesc.Location = new System.Drawing.Point(411, 21);
            this.lblTitleDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDesc.Name = "lblTitleDesc";
            this.lblTitleDesc.Size = new System.Drawing.Size(147, 20);
            this.lblTitleDesc.TabIndex = 3;
            this.lblTitleDesc.Text = "Baseball Scorecard";
            // 
            // lblSelectLeague
            // 
            this.lblSelectLeague.AutoSize = true;
            this.lblSelectLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLeague.Location = new System.Drawing.Point(12, 86);
            this.lblSelectLeague.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectLeague.Name = "lblSelectLeague";
            this.lblSelectLeague.Size = new System.Drawing.Size(107, 15);
            this.lblSelectLeague.TabIndex = 5;
            this.lblSelectLeague.Text = "Select  League:";
            // 
            // lblTeamLabel
            // 
            this.lblTeamLabel.AutoSize = true;
            this.lblTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamLabel.Location = new System.Drawing.Point(298, 86);
            this.lblTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamLabel.Name = "lblTeamLabel";
            this.lblTeamLabel.Size = new System.Drawing.Size(47, 15);
            this.lblTeamLabel.TabIndex = 6;
            this.lblTeamLabel.Text = "Team:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(541, 86);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(51, 15);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "Player:";
            // 
            // cboPlayer
            // 
            this.cboPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "lastname", true));
            this.cboPlayer.DataSource = this.playerBindingSource;
            this.cboPlayer.DisplayMember = "lastname";
            this.cboPlayer.FormattingEnabled = true;
            this.cboPlayer.Location = new System.Drawing.Point(600, 82);
            this.cboPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPlayer.Name = "cboPlayer";
            this.cboPlayer.Size = new System.Drawing.Size(141, 23);
            this.cboPlayer.TabIndex = 10;
            this.cboPlayer.ValueMember = "lastname";
            this.cboPlayer.Visible = false;
            this.cboPlayer.SelectedIndexChanged += new System.EventHandler(this.cboPlayer_SelectedIndexChanged);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ScoreTrend.player);
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.statisticBindingSource1, "playerPhoto", true));
            this.pbxPlayer.Image = global::ScoreTrend.Properties.Resources.noPhotoAvail;
            this.pbxPlayer.Location = new System.Drawing.Point(109, 165);
            this.pbxPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(176, 201);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 4;
            this.pbxPlayer.TabStop = false;
            // 
            // statisticBindingSource1
            // 
            this.statisticBindingSource1.DataSource = typeof(ScoreTrend.statistic);
            // 
            // btnDashExit
            // 
            this.btnDashExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashExit.Location = new System.Drawing.Point(632, 472);
            this.btnDashExit.Name = "btnDashExit";
            this.btnDashExit.Size = new System.Drawing.Size(109, 32);
            this.btnDashExit.TabIndex = 11;
            this.btnDashExit.Text = "Exit";
            this.btnDashExit.UseVisualStyleBackColor = true;
            this.btnDashExit.Click += new System.EventHandler(this.btnDashExit_Click);
            // 
            // cboLeagues
            // 
            this.cboLeagues.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leagueBindingSource, "name", true));
            this.cboLeagues.DataSource = this.leagueBindingSource;
            this.cboLeagues.DisplayMember = "name";
            this.cboLeagues.FormattingEnabled = true;
            this.cboLeagues.Location = new System.Drawing.Point(139, 82);
            this.cboLeagues.Name = "cboLeagues";
            this.cboLeagues.Size = new System.Drawing.Size(143, 23);
            this.cboLeagues.TabIndex = 12;
            this.cboLeagues.ValueMember = "leagueid";
            this.cboLeagues.SelectedIndexChanged += new System.EventHandler(this.cboLeagues_SelectedIndexChanged);
            // 
            // leagueBindingSource
            // 
            this.leagueBindingSource.DataSource = typeof(ScoreTrend.league);
            // 
            // cboTeam
            // 
            this.cboTeam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "name", true));
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(367, 82);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(151, 23);
            this.cboTeam.TabIndex = 13;
            this.cboTeam.ValueMember = "teamid";
            this.cboTeam.Visible = false;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(131, 400);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(131, 23);
            this.btnEditProfile.TabIndex = 15;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // btnEnterGameInfo
            // 
            this.btnEnterGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterGameInfo.Location = new System.Drawing.Point(453, 400);
            this.btnEnterGameInfo.Name = "btnEnterGameInfo";
            this.btnEnterGameInfo.Size = new System.Drawing.Size(136, 23);
            this.btnEnterGameInfo.TabIndex = 16;
            this.btnEnterGameInfo.Text = "Enter Game Info.";
            this.btnEnterGameInfo.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "firstname", true));
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(507, 153);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 15);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "John";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "lastname", true));
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(581, 153);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(30, 15);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Doe";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLastName.Visible = false;
            // 
            // lblStrikeouts
            // 
            this.lblStrikeouts.AutoSize = true;
            this.lblStrikeouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikeouts.Location = new System.Drawing.Point(428, 191);
            this.lblStrikeouts.Name = "lblStrikeouts";
            this.lblStrikeouts.Size = new System.Drawing.Size(77, 15);
            this.lblStrikeouts.TabIndex = 19;
            this.lblStrikeouts.Text = "StrikeOuts:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(428, 351);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(47, 15);
            this.lblTeam.TabIndex = 20;
            this.lblTeam.Text = "Team:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(428, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name:";
            // 
            // lblStrikeOutData
            // 
            this.lblStrikeOutData.AutoSize = true;
            this.lblStrikeOutData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statisticBindingSource1, "strikeouts", true));
            this.lblStrikeOutData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikeOutData.Location = new System.Drawing.Point(583, 191);
            this.lblStrikeOutData.Name = "lblStrikeOutData";
            this.lblStrikeOutData.Size = new System.Drawing.Size(28, 15);
            this.lblStrikeOutData.TabIndex = 22;
            this.lblStrikeOutData.Text = "204";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(602, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 23;
            // 
            // lblRunsScored
            // 
            this.lblRunsScored.AutoSize = true;
            this.lblRunsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunsScored.Location = new System.Drawing.Point(428, 308);
            this.lblRunsScored.Name = "lblRunsScored";
            this.lblRunsScored.Size = new System.Drawing.Size(93, 15);
            this.lblRunsScored.TabIndex = 24;
            this.lblRunsScored.Text = "Runs Scored:";
            // 
            // lblRunsScoredData
            // 
            this.lblRunsScoredData.AutoSize = true;
            this.lblRunsScoredData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statisticBindingSource1, "runs", true));
            this.lblRunsScoredData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunsScoredData.Location = new System.Drawing.Point(590, 308);
            this.lblRunsScoredData.Name = "lblRunsScoredData";
            this.lblRunsScoredData.Size = new System.Drawing.Size(21, 15);
            this.lblRunsScoredData.TabIndex = 25;
            this.lblRunsScoredData.Text = "12";
            // 
            // lblTeamData
            // 
            this.lblTeamData.AutoSize = true;
            this.lblTeamData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "team.name", true));
            this.lblTeamData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamData.Location = new System.Drawing.Point(522, 351);
            this.lblTeamData.Name = "lblTeamData";
            this.lblTeamData.Size = new System.Drawing.Size(91, 15);
            this.lblTeamData.TabIndex = 26;
            this.lblTeamData.Text = "Orlando Braves";
            // 
            // lblBattingAvg
            // 
            this.lblBattingAvg.AutoSize = true;
            this.lblBattingAvg.Location = new System.Drawing.Point(428, 229);
            this.lblBattingAvg.Name = "lblBattingAvg";
            this.lblBattingAvg.Size = new System.Drawing.Size(86, 15);
            this.lblBattingAvg.TabIndex = 27;
            this.lblBattingAvg.Text = "Batting Avg.:";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(428, 267);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(36, 15);
            this.lblHits.TabIndex = 28;
            this.lblHits.Text = "Hits:";
            // 
            // lblBatAvgData
            // 
            this.lblBatAvgData.AutoSize = true;
            this.lblBatAvgData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statisticBindingSource1, "batAvg", true));
            this.lblBatAvgData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatAvgData.Location = new System.Drawing.Point(580, 229);
            this.lblBatAvgData.Name = "lblBatAvgData";
            this.lblBatAvgData.Size = new System.Drawing.Size(31, 15);
            this.lblBatAvgData.TabIndex = 29;
            this.lblBatAvgData.Text = ".650";
            // 
            // lblHitsData
            // 
            this.lblHitsData.AutoSize = true;
            this.lblHitsData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statisticBindingSource1, "hits", true));
            this.lblHitsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitsData.Location = new System.Drawing.Point(583, 267);
            this.lblHitsData.Name = "lblHitsData";
            this.lblHitsData.Size = new System.Drawing.Size(28, 15);
            this.lblHitsData.TabIndex = 30;
            this.lblHitsData.Text = "115";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(ScoreTrend.team);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.lblHitsData);
            this.Controls.Add(this.lblBatAvgData);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.lblBattingAvg);
            this.Controls.Add(this.lblTeamData);
            this.Controls.Add(this.lblRunsScoredData);
            this.Controls.Add(this.lblRunsScored);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblStrikeOutData);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblStrikeouts);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnEnterGameInfo);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.cboLeagues);
            this.Controls.Add(this.btnDashExit);
            this.Controls.Add(this.cboPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTeamLabel);
            this.Controls.Add(this.lblSelectLeague);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.lblTitleDesc);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "ScoreTrend Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleDesc;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Label lblSelectLeague;
        private System.Windows.Forms.Label lblTeamLabel;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.ComboBox cboPlayer;
        private System.Windows.Forms.Button btnDashExit;
        private System.Windows.Forms.ComboBox cboLeagues;
        private System.Windows.Forms.BindingSource leagueBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnEnterGameInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStrikeouts;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStrikeOutData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRunsScored;
        private System.Windows.Forms.Label lblRunsScoredData;
        private System.Windows.Forms.Label lblTeamData;
        private System.Windows.Forms.Label lblBattingAvg;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblBatAvgData;
        private System.Windows.Forms.Label lblHitsData;
        private System.Windows.Forms.BindingSource statisticBindingSource;
        private System.Windows.Forms.BindingSource statisticBindingSource1;
        private System.Windows.Forms.BindingSource teamBindingSource;
    }
}