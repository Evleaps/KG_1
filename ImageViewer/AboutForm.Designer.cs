namespace ImageViewer
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            initPicture(this);
            initHeader(this);
            initVersionLabel(this);
            initPositiveButton(this);
            initHelp(this);

        }


        /*
        * Picture
        */
        private void initPicture(AboutForm aboutForm) {
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PositiveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            this.SuspendLayout();

            this.aboutPictureBox.Image = global::ImageViewer.Properties.Resources._2;
            this.aboutPictureBox.Location = new System.Drawing.Point(12, 12);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(227, 228);
            this.aboutPictureBox.TabIndex = 0;
            this.aboutPictureBox.TabStop = false;
        }

        /*
        * Header
        */
        private void initHeader(AboutForm aboutForm) {
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Viewer";
        }

        /*
        * Version Label
        */
        private void initVersionLabel(AboutForm aboutForm) {
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 1.0";
        }

        /*
        * Help
        */
        private void initHelp(AboutForm aboutForm) {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 172);
            this.Controls.Add(this.PositiveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutPictureBox);
            this.Name = "Help";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /*
        * Positive Button
        */
        private void initPositiveButton(AboutForm aboutForm) {
            aboutForm.PositiveButton.Location = new System.Drawing.Point(195, 126);
            aboutForm.PositiveButton.Name = "positiveButton";
            aboutForm.PositiveButton.Size = new System.Drawing.Size(123, 34);
            aboutForm.PositiveButton.TabIndex = 3;
            aboutForm.PositiveButton.Text = "OK";
            aboutForm.PositiveButton.UseVisualStyleBackColor = true;
            aboutForm.PositiveButton.Click += new System.EventHandler(this.positiveButtonListener);
        }

        #endregion

        private System.Windows.Forms.PictureBox aboutPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PositiveButton;
    }
}