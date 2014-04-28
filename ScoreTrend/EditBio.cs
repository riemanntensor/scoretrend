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
    public partial class EditBio : Form
    {
        public EditBio()
        {
            InitializeComponent();
        }

        private void EditBio_Load(object sender, EventArgs e)
        {

        }

        private void pboEditBioImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog insertImage = new OpenFileDialog();

            insertImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            insertImage.FilterIndex = 1;

            DialogResult dr = insertImage.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in insertImage.FileNames)
                {
                    try
                    {
                        Image loadedImage = Image.FromFile(file);
                        pboEditBioImage.Image = loadedImage;
                        pboEditBioImage.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                    + ". You may not have permission to read the file, or " +
                    "it may be corrupt.\n\nReported error: " + ex.Message);

                    }
                }
                
            }
            
        }

        public ScoreTrendDataClassesDataContext context = new ScoreTrendDataClassesDataContext();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to Exit ScoreTrend?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }
    }
}
