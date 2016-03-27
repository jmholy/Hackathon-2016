namespace HMM_P3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.hypnoToad = new System.Windows.Forms.ToolStripMenuItem();
            this.windows98HELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeBox1 = new System.Windows.Forms.TextBox();
            this.timeBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.songInfoBox = new System.Windows.Forms.TextBox();
            this.songBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.volumeup = new System.Windows.Forms.Button();
            this.volumedown = new System.Windows.Forms.Button();
            this.skipback = new System.Windows.Forms.Button();
            this.skipforward = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.progressBar.Location = new System.Drawing.Point(18, 725);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1465, 39);
            this.progressBar.TabIndex = 10;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1508, 55);
            this.menuStrip1.TabIndex = 13;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 45);
            this.toolStripMenuItem3.Text = "Songs";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(278, 46);
            this.addSongsToolStripMenuItem.Text = "Add Songs";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.basicTheme,
            this.hypnoToad,
            this.windows98HELLToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 45);
            this.toolStripMenuItem1.Text = "Themes";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(368, 46);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // basicTheme
            // 
            this.basicTheme.Name = "basicTheme";
            this.basicTheme.Size = new System.Drawing.Size(368, 46);
            this.basicTheme.Text = "Basic";
            this.basicTheme.Click += new System.EventHandler(this.basicTheme_Click);
            // 
            // hypnoToad
            // 
            this.hypnoToad.Name = "hypnoToad";
            this.hypnoToad.Size = new System.Drawing.Size(368, 46);
            this.hypnoToad.Text = "Hypno Toad";
            this.hypnoToad.Click += new System.EventHandler(this.hypnoToad_Click);
            // 
            // windows98HELLToolStripMenuItem
            // 
            this.windows98HELLToolStripMenuItem.Name = "windows98HELLToolStripMenuItem";
            this.windows98HELLToolStripMenuItem.Size = new System.Drawing.Size(368, 46);
            this.windows98HELLToolStripMenuItem.Text = "Windows 98 HELL";
            this.windows98HELLToolStripMenuItem.Click += new System.EventHandler(this.windows98HELLToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // timeBox1
            // 
            this.timeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox1.Location = new System.Drawing.Point(21, 690);
            this.timeBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.timeBox1.Name = "timeBox1";
            this.timeBox1.Size = new System.Drawing.Size(263, 31);
            this.timeBox1.TabIndex = 11;
            // 
            // timeBox2
            // 
            this.timeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox2.Location = new System.Drawing.Point(1216, 690);
            this.timeBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.timeBox2.Name = "timeBox2";
            this.timeBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeBox2.Size = new System.Drawing.Size(263, 31);
            this.timeBox2.TabIndex = 12;
            this.timeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // songInfoBox
            // 
            this.songInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songInfoBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.songInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songInfoBox.Location = new System.Drawing.Point(297, 676);
            this.songInfoBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.songInfoBox.Name = "songInfoBox";
            this.songInfoBox.Size = new System.Drawing.Size(907, 31);
            this.songInfoBox.TabIndex = 15;
            this.songInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // songBox
            // 
            this.songBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songBox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.songBox.Location = new System.Drawing.Point(25, 59);
            this.songBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.songBox.Multiline = true;
            this.songBox.Name = "songBox";
            this.songBox.ReadOnly = true;
            this.songBox.Size = new System.Drawing.Size(548, 595);
            this.songBox.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(587, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 637);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Size = new System.Drawing.Size(880, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HMM_P3.Properties.Resources.boring;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage2.Size = new System.Drawing.Size(880, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Random Gifs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(5, -5);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(36, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(880, 591);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.gifff.in/", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser2);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(880, 579);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Random Video";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.AllowNavigation = false;
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(36, 31);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(880, 579);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ?version3", System.UriKind.Absolute);
            // 
            // volumeup
            // 
            this.volumeup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeup.AutoSize = true;
            this.volumeup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeup.Image = ((System.Drawing.Image)(resources.GetObject("volumeup.Image")));
            this.volumeup.Location = new System.Drawing.Point(1252, 780);
            this.volumeup.Margin = new System.Windows.Forms.Padding(0);
            this.volumeup.Name = "volumeup";
            this.volumeup.Size = new System.Drawing.Size(228, 198);
            this.volumeup.TabIndex = 9;
            this.volumeup.UseVisualStyleBackColor = true;
            this.volumeup.Click += new System.EventHandler(this.volumeup_Click);
            // 
            // volumedown
            // 
            this.volumedown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumedown.AutoSize = true;
            this.volumedown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumedown.Image = ((System.Drawing.Image)(resources.GetObject("volumedown.Image")));
            this.volumedown.Location = new System.Drawing.Point(1006, 780);
            this.volumedown.Margin = new System.Windows.Forms.Padding(0);
            this.volumedown.Name = "volumedown";
            this.volumedown.Size = new System.Drawing.Size(228, 198);
            this.volumedown.TabIndex = 8;
            this.volumedown.UseVisualStyleBackColor = true;
            this.volumedown.Click += new System.EventHandler(this.volumedown_Click);
            // 
            // skipback
            // 
            this.skipback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipback.AutoSize = true;
            this.skipback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipback.Image = ((System.Drawing.Image)(resources.GetObject("skipback.Image")));
            this.skipback.Location = new System.Drawing.Point(25, 780);
            this.skipback.Margin = new System.Windows.Forms.Padding(0);
            this.skipback.Name = "skipback";
            this.skipback.Size = new System.Drawing.Size(228, 198);
            this.skipback.TabIndex = 6;
            this.skipback.UseVisualStyleBackColor = true;
            this.skipback.Click += new System.EventHandler(this.skipback_Click);
            // 
            // skipforward
            // 
            this.skipforward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipforward.AutoSize = true;
            this.skipforward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipforward.Image = ((System.Drawing.Image)(resources.GetObject("skipforward.Image")));
            this.skipforward.Location = new System.Drawing.Point(761, 780);
            this.skipforward.Margin = new System.Windows.Forms.Padding(0);
            this.skipforward.Name = "skipforward";
            this.skipforward.Size = new System.Drawing.Size(228, 198);
            this.skipforward.TabIndex = 3;
            this.skipforward.UseVisualStyleBackColor = true;
            this.skipforward.Click += new System.EventHandler(this.skipforward_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.AutoSize = true;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(516, 780);
            this.pause.Margin = new System.Windows.Forms.Padding(0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(228, 198);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.AutoSize = true;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(270, 780);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(228, 198);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 1006);
            this.Controls.Add(this.songInfoBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.timeBox2);
            this.Controls.Add(this.timeBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.volumeup);
            this.Controls.Add(this.volumedown);
            this.Controls.Add(this.skipback);
            this.Controls.Add(this.skipforward);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Cougar Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button skipforward;
        private System.Windows.Forms.Button skipback;
        private System.Windows.Forms.Button volumedown;
        private System.Windows.Forms.Button volumeup;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TextBox timeBox1;
        private System.Windows.Forms.TextBox timeBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem basicTheme;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hypnoToad;
        private System.Windows.Forms.TextBox songInfoBox;
        private System.Windows.Forms.TextBox songBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows98HELLToolStripMenuItem;
    }
}

