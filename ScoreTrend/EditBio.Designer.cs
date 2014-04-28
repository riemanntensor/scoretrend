namespace ScoreTrend
{
    partial class EditBio
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
            this.lblEditBioTitleDesc = new System.Windows.Forms.Label();
            this.lblEditYourBio = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pboEditBioImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboEditBioImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEditBiolTitle
            // 
            this.lbEditBiolTitle.AutoSize = true;
            this.lbEditBiolTitle.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditBiolTitle.Location = new System.Drawing.Point(121, 19);
            this.lbEditBiolTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEditBiolTitle.Name = "lbEditBiolTitle";
            this.lbEditBiolTitle.Size = new System.Drawing.Size(189, 35);
            this.lbEditBiolTitle.TabIndex = 3;
            this.lbEditBiolTitle.Text = "ScoreTrend";
            // 
            // lblEditBioTitleDesc
            // 
            this.lblEditBioTitleDesc.AutoSize = true;
            this.lblEditBioTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBioTitleDesc.Location = new System.Drawing.Point(339, 31);
            this.lblEditBioTitleDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditBioTitleDesc.Name = "lblEditBioTitleDesc";
            this.lblEditBioTitleDesc.Size = new System.Drawing.Size(147, 20);
            this.lblEditBioTitleDesc.TabIndex = 4;
            this.lblEditBioTitleDesc.Text = "Baseball Scorecard";
            // 
            // lblEditYourBio
            // 
            this.lblEditYourBio.AutoSize = true;
            this.lblEditYourBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditYourBio.Location = new System.Drawing.Point(147, 124);
            this.lblEditYourBio.Name = "lblEditYourBio";
            this.lblEditYourBio.Size = new System.Drawing.Size(304, 16);
            this.lblEditYourBio.TabIndex = 5;
            this.lblEditYourBio.Text = "Click on image to update your player photo";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(395, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(506, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pboEditBioImage
            // 
            this.pboEditBioImage.Image = global::ScoreTrend.Properties.Resources.noPhotoAvail;
            this.pboEditBioImage.Location = new System.Drawing.Point(216, 170);
            this.pboEditBioImage.Name = "pboEditBioImage";
            this.pboEditBioImage.Size = new System.Drawing.Size(164, 186);
            this.pboEditBioImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboEditBioImage.TabIndex = 0;
            this.pboEditBioImage.TabStop = false;
            this.pboEditBioImage.Click += new System.EventHandler(this.pboEditBioImage_Click);
            // 
            // EditBio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 532);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblEditYourBio);
            this.Controls.Add(this.lblEditBioTitleDesc);
            this.Controls.Add(this.lbEditBiolTitle);
            this.Controls.Add(this.pboEditBioImage);
            this.Name = "EditBio";
            this.Text = "EditBio";
            this.Load += new System.EventHandler(this.EditBio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboEditBioImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboEditBioImage;
        private System.Windows.Forms.Label lbEditBiolTitle;
        private System.Windows.Forms.Label lblEditBioTitleDesc;
        private System.Windows.Forms.Label lblEditYourBio;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}