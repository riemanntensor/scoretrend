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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPlayer = new System.Windows.Forms.ComboBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.btnDashExit = new System.Windows.Forms.Button();
            this.cboLeagues = new System.Windows.Forms.ComboBox();
            this.leagueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select  League:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player:";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(ScoreTrend.team);
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
            this.pbxPlayer.Location = new System.Drawing.Point(70, 195);
            this.pbxPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(173, 201);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 4;
            this.pbxPlayer.TabStop = false;
            // 
            // btnDashExit
            // 
            this.btnDashExit.Location = new System.Drawing.Point(632, 464);
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
            this.cboLeagues.ValueMember = "name";
            this.cboLeagues.SelectedIndexChanged += new System.EventHandler(this.cboLeagues_SelectedIndexChanged);
            // 
            // leagueBindingSource
            // 
            this.leagueBindingSource.DataSource = typeof(ScoreTrend.league);
            // 
            // cboTeam
            // 
            this.cboTeam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "name", true));
            this.cboTeam.DataSource = this.teamBindingSource;
            this.cboTeam.DisplayMember = "name";
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(367, 82);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(151, 23);
            this.cboTeam.TabIndex = 13;
            this.cboTeam.ValueMember = "name";
            this.cboTeam.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 516);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.cboLeagues);
            this.Controls.Add(this.btnDashExit);
            this.Controls.Add(this.cboPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.lblTitleDesc);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "ScoreTrend Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleDesc;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPlayer;
        private System.Windows.Forms.Button btnDashExit;
        private System.Windows.Forms.ComboBox cboLeagues;
        private System.Windows.Forms.BindingSource leagueBindingSource;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.ComboBox cboTeam;
    }
}