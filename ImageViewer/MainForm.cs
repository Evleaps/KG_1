using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        private void MenuItemOpen_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = new Bitmap(dlg.FileName);
                pictureBox.Refresh();
            }
        }

        private void SetSizeMode() {
            if (RadioButtonNormal.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            else if (RadioButtonStretchImage.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (RadioButtonCenterImage.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            else if (RadioButtonZoom.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void MenuItemExit_Click(object sender, EventArgs e) {  Close(); }

        private void RadioButtonNormal_CheckedChanged(object sender, EventArgs e) { SetSizeMode(); }

        private void RadioButtonStretchImage_CheckedChanged(object sender, EventArgs e) { SetSizeMode(); }

        private void RadioButtonCenterImage_CheckedChanged(object sender, EventArgs e) {   SetSizeMode(); }

        private void RadioButtonZoom_CheckedChanged(object sender, EventArgs e) {  SetSizeMode(); }

        private void MenuItemAboutProgram_Click(object sender, EventArgs e) {
            AboutForm about = new AboutForm();

            about.Show();
        }
    }
}
