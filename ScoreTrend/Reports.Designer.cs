namespace ScoreTrend
{
    partial class Reports
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
            this.lbEditBiolTitle = new System.Windows.Forms.Label();
            this.lblTitleDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEditBiolTitle
            // 
            this.lbEditBiolTitle.AutoSize = true;
            this.lbEditBiolTitle.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditBiolTitle.Location = new System.Drawing.Point(98, 69);
            this.lbEditBiolTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEditBiolTitle.Name = "lbEditBiolTitle";
            this.lbEditBiolTitle.Size = new System.Drawing.Size(189, 35);
            this.lbEditBiolTitle.TabIndex = 4;
            this.lbEditBiolTitle.Text = "ScoreTrend";
            // 
            // lblTitleDesc
            // 
            this.lblTitleDesc.AutoSize = true;
            this.lblTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDesc.Location = new System.Drawing.Point(341, 81);
            this.lblTitleDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDesc.Name = "lblTitleDesc";
            this.lblTitleDesc.Size = new System.Drawing.Size(147, 20);
            this.lblTitleDesc.TabIndex = 5;
            this.lblTitleDesc.Text = "Baseball Scorecard";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 519);
            this.Controls.Add(this.lblTitleDesc);
            this.Controls.Add(this.lbEditBiolTitle);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEditBiolTitle;
        private System.Windows.Forms.Label lblTitleDesc;
    }
}