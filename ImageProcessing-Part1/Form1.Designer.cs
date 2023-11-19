namespace ImageProcessing_Part1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            addFileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            imageProcessToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            scepiaToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addFileToolStripMenuItem, imageProcessToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // addFileToolStripMenuItem
            // 
            resources.ApplyResources(addFileToolStripMenuItem, "addFileToolStripMenuItem");
            addFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(closeToolStripMenuItem, "closeToolStripMenuItem");
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // imageProcessToolStripMenuItem
            // 
            resources.ApplyResources(imageProcessToolStripMenuItem, "imageProcessToolStripMenuItem");
            imageProcessToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, scepiaToolStripMenuItem });
            imageProcessToolStripMenuItem.Name = "imageProcessToolStripMenuItem";
            // 
            // basicCopyToolStripMenuItem
            // 
            resources.ApplyResources(basicCopyToolStripMenuItem, "basicCopyToolStripMenuItem");
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            resources.ApplyResources(greyscaleToolStripMenuItem, "greyscaleToolStripMenuItem");
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            resources.ApplyResources(colorInversionToolStripMenuItem, "colorInversionToolStripMenuItem");
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Click += colorInversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            resources.ApplyResources(histogramToolStripMenuItem, "histogramToolStripMenuItem");
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // scepiaToolStripMenuItem
            // 
            resources.ApplyResources(scepiaToolStripMenuItem, "scepiaToolStripMenuItem");
            scepiaToolStripMenuItem.Name = "scepiaToolStripMenuItem";
            scepiaToolStripMenuItem.Click += scepiaToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(openFileDialog1, "openFileDialog1");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(saveFileDialog1, "saveFileDialog1");
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripMenuItem imageProcessToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem scepiaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}