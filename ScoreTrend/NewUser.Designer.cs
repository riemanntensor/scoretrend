namespace ScoreTrend
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleDesc = new System.Windows.Forms.Label();
            this.lblSignUpTitle = new System.Windows.Forms.Label();
            this.lblStartRecordingTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPickLeague = new System.Windows.Forms.Label();
            this.lblPickYourTeam = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAreYouTheAuth = new System.Windows.Forms.Label();
            this.radYesAuth = new System.Windows.Forms.RadioButton();
            this.radNoAuth = new System.Windows.Forms.RadioButton();
            this.cboPickYourLeague = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblErrMessageNewUser = new System.Windows.Forms.Label();
            this.cboPickYourTeam = new System.Windows.Forms.ComboBox();
            this.leagueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ScoreTrend";
            // 
            // lblTitleDesc
            // 
            this.lblTitleDesc.AutoSize = true;
            this.lblTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDesc.Location = new System.Drawing.Point(359, 102);
            this.lblTitleDesc.Name = "lblTitleDesc";
            this.lblTitleDesc.Size = new System.Drawing.Size(147, 20);
            this.lblTitleDesc.TabIndex = 2;
            this.lblTitleDesc.Text = "Baseball Scorecard";
            // 
            // lblSignUpTitle
            // 
            this.lblSignUpTitle.AutoSize = true;
            this.lblSignUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpTitle.Location = new System.Drawing.Point(233, 199);
            this.lblSignUpTitle.Name = "lblSignUpTitle";
            this.lblSignUpTitle.Size = new System.Drawing.Size(101, 16);
            this.lblSignUpTitle.TabIndex = 3;
            this.lblSignUpTitle.Text = "Sign Up Now!";
            // 
            // lblStartRecordingTitle
            // 
            this.lblStartRecordingTitle.AutoSize = true;
            this.lblStartRecordingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartRecordingTitle.Location = new System.Drawing.Point(160, 229);
            this.lblStartRecordingTitle.Name = "lblStartRecordingTitle";
            this.lblStartRecordingTitle.Size = new System.Drawing.Size(261, 16);
            this.lblStartRecordingTitle.TabIndex = 4;
            this.lblStartRecordingTitle.Text = "Start recording your player statistics!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 168);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblPickLeague
            // 
            this.lblPickLeague.AutoSize = true;
            this.lblPickLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickLeague.Location = new System.Drawing.Point(95, 276);
            this.lblPickLeague.Name = "lblPickLeague";
            this.lblPickLeague.Size = new System.Drawing.Size(128, 16);
            this.lblPickLeague.TabIndex = 6;
            this.lblPickLeague.Text = "1. Pick your League.";
            // 
            // lblPickYourTeam
            // 
            this.lblPickYourTeam.AutoSize = true;
            this.lblPickYourTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickYourTeam.Location = new System.Drawing.Point(95, 307);
            this.lblPickYourTeam.Name = "lblPickYourTeam";
            this.lblPickYourTeam.Size = new System.Drawing.Size(121, 16);
            this.lblPickYourTeam.TabIndex = 7;
            this.lblPickYourTeam.Text = "2.  Pick your Team.";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(431, 484);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAreYouTheAuth
            // 
            this.lblAreYouTheAuth.AutoSize = true;
            this.lblAreYouTheAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouTheAuth.Location = new System.Drawing.Point(95, 338);
            this.lblAreYouTheAuth.Name = "lblAreYouTheAuth";
            this.lblAreYouTheAuth.Size = new System.Drawing.Size(246, 16);
            this.lblAreYouTheAuth.TabIndex = 10;
            this.lblAreYouTheAuth.Text = "3.  Are you the Authorized Scorekeeper?";
            // 
            // radYesAuth
            // 
            this.radYesAuth.AutoSize = true;
            this.radYesAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYesAuth.Location = new System.Drawing.Point(377, 336);
            this.radYesAuth.Name = "radYesAuth";
            this.radYesAuth.Size = new System.Drawing.Size(53, 20);
            this.radYesAuth.TabIndex = 11;
            this.radYesAuth.TabStop = true;
            this.radYesAuth.Text = "Yes.";
            this.radYesAuth.UseVisualStyleBackColor = true;
            // 
            // radNoAuth
            // 
            this.radNoAuth.AutoSize = true;
            this.radNoAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNoAuth.Location = new System.Drawing.Point(437, 336);
            this.radNoAuth.Name = "radNoAuth";
            this.radNoAuth.Size = new System.Drawing.Size(47, 20);
            this.radNoAuth.TabIndex = 12;
            this.radNoAuth.TabStop = true;
            this.radNoAuth.Text = "No.";
            this.radNoAuth.UseVisualStyleBackColor = true;
            // 
            // cboPickYourLeague
            // 
            this.cboPickYourLeague.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leagueBindingSource, "name", true));
            this.cboPickYourLeague.DisplayMember = "name";
            this.cboPickYourLeague.FormattingEnabled = true;
            this.cboPickYourLeague.Location = new System.Drawing.Point(363, 271);
            this.cboPickYourLeague.Name = "cboPickYourLeague";
            this.cboPickYourLeague.Size = new System.Drawing.Size(121, 21);
            this.cboPickYourLeague.TabIndex = 13;
            this.cboPickYourLeague.ValueMember = "leagueid";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(95, 369);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(204, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "4. Please enter a new Username.";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(97, 400);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(201, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "5. Please enter a new Password.";
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "username", true));
            this.txtUsername.Location = new System.Drawing.Point(363, 365);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUsername.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.txtPassword.Location = new System.Drawing.Point(363, 395);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // lblErrMessageNewUser
            // 
            this.lblErrMessageNewUser.AutoSize = true;
            this.lblErrMessageNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMessageNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrMessageNewUser.Location = new System.Drawing.Point(28, 489);
            this.lblErrMessageNewUser.Name = "lblErrMessageNewUser";
            this.lblErrMessageNewUser.Size = new System.Drawing.Size(284, 13);
            this.lblErrMessageNewUser.TabIndex = 19;
            this.lblErrMessageNewUser.Text = "***Error Message and Info Message Goes Here...";
            this.lblErrMessageNewUser.Visible = false;
            // 
            // cboPickYourTeam
            // 
            this.cboPickYourTeam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "name", true));
            this.cboPickYourTeam.FormattingEnabled = true;
            this.cboPickYourTeam.Location = new System.Drawing.Point(363, 302);
            this.cboPickYourTeam.Name = "cboPickYourTeam";
            this.cboPickYourTeam.Size = new System.Drawing.Size(121, 21);
            this.cboPickYourTeam.TabIndex = 20;
            // 
            // leagueBindingSource
            // 
            this.leagueBindingSource.DataSource = typeof(ScoreTrend.league);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(ScoreTrend.team);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ScoreTrend.user);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 519);
            this.Controls.Add(this.cboPickYourTeam);
            this.Controls.Add(this.lblErrMessageNewUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cboPickYourLeague);
            this.Controls.Add(this.radNoAuth);
            this.Controls.Add(this.radYesAuth);
            this.Controls.Add(this.lblAreYouTheAuth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPickYourTeam);
            this.Controls.Add(this.lblPickLeague);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStartRecordingTitle);
            this.Controls.Add(this.lblSignUpTitle);
            this.Controls.Add(this.lblTitleDesc);
            this.Controls.Add(this.lblTitle);
            this.Name = "NewUser";
            this.Text = "New User Setup";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleDesc;
        private System.Windows.Forms.Label lblSignUpTitle;
        private System.Windows.Forms.Label lblStartRecordingTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPickLeague;
        private System.Windows.Forms.Label lblPickYourTeam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAreYouTheAuth;
        private System.Windows.Forms.RadioButton radYesAuth;
        private System.Windows.Forms.RadioButton radNoAuth;
        private System.Windows.Forms.ComboBox cboPickYourLeague;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblErrMessageNewUser;
        private System.Windows.Forms.ComboBox cboPickYourTeam;
        private System.Windows.Forms.BindingSource leagueBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource teamBindingSource;
        
        
    }
}