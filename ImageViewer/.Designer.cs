namespace ImageViewer {

    /*
     *  @author Aymaletdinov Roman
     */
    partial class MainForm {

        private System.ComponentModel.IContainer components = null;

  
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
      
        private void InitializeComponent() {
            initMenuStrip(this);
            initFile(this);

            initOpen(this);
            initExit(this);
            initStripMenu(this);
            initOptions(this);
            initAbout(this);

            initRadioButtonZoom(this);
            initRadioButtonCenter(this);
            initRadioButtonStretch(this);
            initRadioButtonNormal(this);

            initPicture(this);
            initMainForm(this);
        }

        /* 
        * Menu Strip
        */
        private void initMenuStrip(MainForm mainForm)
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.RadioButtonZoom = new System.Windows.Forms.RadioButton();
            this.RadioButtonCenterImage = new System.Windows.Forms.RadioButton();
            this.RadioButtonStretchImage = new System.Windows.Forms.RadioButton();
            this.RadioButtonNormal = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(606, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
        }


        /* 
         * File
         */
        private void initFile(MainForm mainForm)
        {
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpen,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "File";
        }

        /* 
         * Open
         */
        private void initOpen(MainForm mainForm)
        {
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuItemOpen.Text = "Open";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
        }

        /* 
         * Exit
         */
        private void initExit(MainForm mainForm)
        {
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
        }


        /* 
         * StripMenu
         */
        private void initStripMenu(MainForm mainForm)
        {
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAboutProgram});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "Help";
        }

        /* 
         * About
         */
        private void initAbout(MainForm mainForm)
        {
            this.MenuItemAboutProgram.Name = "MenuItemAboutProgram";
            this.MenuItemAboutProgram.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItemAboutProgram.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAboutProgram.Text = "About";
            this.MenuItemAboutProgram.Click += new System.EventHandler(this.MenuItemAboutProgram_Click);
        }


        /* 
         * Options
         */
        private void initOptions(MainForm mainForm)
        {
            this.groupBoxOptions.Controls.Add(this.RadioButtonZoom);
            this.groupBoxOptions.Controls.Add(this.RadioButtonCenterImage);
            this.groupBoxOptions.Controls.Add(this.RadioButtonStretchImage);
            this.groupBoxOptions.Controls.Add(this.RadioButtonNormal);
            this.groupBoxOptions.Location = new System.Drawing.Point(441, 27);
            this.groupBoxOptions.Name = "scalingOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(165, 171);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "scaling type:";
        }

        /* 
        * RadioButtonZoom
        */
        private void initRadioButtonZoom(MainForm mainForm)
        {
            this.RadioButtonZoom.AutoSize = true;
            this.RadioButtonZoom.Location = new System.Drawing.Point(22, 125);
            this.RadioButtonZoom.Name = "RadioButtonZoom";
            this.RadioButtonZoom.Size = new System.Drawing.Size(52, 17);
            this.RadioButtonZoom.TabIndex = 3;
            this.RadioButtonZoom.TabStop = true;
            this.RadioButtonZoom.Text = "Zoom";
            this.RadioButtonZoom.UseVisualStyleBackColor = true;
            this.RadioButtonZoom.CheckedChanged += new System.EventHandler(this.RadioButtonZoom_CheckedChanged);
        }

        /* 
        * RadioButtonCenter
        */
        private void initRadioButtonCenter(MainForm mainForm)
        {
            this.RadioButtonCenterImage.AutoSize = true;
            this.RadioButtonCenterImage.Location = new System.Drawing.Point(22, 95);
            this.RadioButtonCenterImage.Name = "RadioButtonCenterImage";
            this.RadioButtonCenterImage.Size = new System.Drawing.Size(88, 17);
            this.RadioButtonCenterImage.TabIndex = 2;
            this.RadioButtonCenterImage.TabStop = true;
            this.RadioButtonCenterImage.Text = "Center Image";
            this.RadioButtonCenterImage.UseVisualStyleBackColor = true;
            this.RadioButtonCenterImage.CheckedChanged += new System.EventHandler(this.RadioButtonCenterImage_CheckedChanged);
        }

        /* 
        * RadioButtonStretch
        */
        private void initRadioButtonStretch(MainForm mainForm)
        {
            this.RadioButtonStretchImage.AutoSize = true;
            this.RadioButtonStretchImage.Location = new System.Drawing.Point(22, 65);
            this.RadioButtonStretchImage.Name = "RadioButtonStretchImage";
            this.RadioButtonStretchImage.Size = new System.Drawing.Size(91, 17);
            this.RadioButtonStretchImage.TabIndex = 1;
            this.RadioButtonStretchImage.TabStop = true;
            this.RadioButtonStretchImage.Text = "Stretch Image";
            this.RadioButtonStretchImage.UseVisualStyleBackColor = true;
            this.RadioButtonStretchImage.CheckedChanged += new System.EventHandler(this.RadioButtonStretchImage_CheckedChanged);

        }

        /* 
        * RadioButtonNormal
        */
        private void initRadioButtonNormal(MainForm mainForm)
        {
            this.RadioButtonNormal.AutoSize = true;
            this.RadioButtonNormal.Checked = true;
            this.RadioButtonNormal.Location = new System.Drawing.Point(22, 35);
            this.RadioButtonNormal.Name = "RadioButtonNormal";
            this.RadioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonNormal.TabIndex = 0;
            this.RadioButtonNormal.TabStop = true;
            this.RadioButtonNormal.Text = "Normal";
            this.RadioButtonNormal.UseVisualStyleBackColor = true;
            this.RadioButtonNormal.CheckedChanged += new System.EventHandler(this.RadioButtonNormal_CheckedChanged);
        }

        /* 
         * Picture
         */
        private void initPicture(MainForm mainForm) {

            this.pictureBox.BackgroundImage = global::ImageViewer.Properties.Resources._1;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = global::ImageViewer.Properties.Resources._3;
            this.pictureBox.Location = new System.Drawing.Point(12, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(423, 416);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 446);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "ImageViewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

       

        /* 
        * MainForm
        */
        private void initMainForm(MainForm mainForm) {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 446);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "ImageViewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton RadioButtonZoom;
        private System.Windows.Forms.RadioButton RadioButtonCenterImage;
        private System.Windows.Forms.RadioButton RadioButtonStretchImage;
        private System.Windows.Forms.RadioButton RadioButtonNormal;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutProgram;
    }
}

