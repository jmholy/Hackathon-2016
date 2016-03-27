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
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.basicTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.hypnoToad = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeBox1 = new System.Windows.Forms.TextBox();
            this.timeBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volumeup = new System.Windows.Forms.Button();
            this.volumedown = new System.Windows.Forms.Button();
            this.skipback = new System.Windows.Forms.Button();
            this.skipforward = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(10, 468);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(824, 25);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(848, 35);
            this.menuStrip1.TabIndex = 13;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(74, 29);
            this.toolStripMenuItem3.Text = "Songs";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 30);
            this.toolStripMenuItem4.Text = "Add Songs";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicTheme,
            this.hypnoToad});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItem1.Text = "Themes";
            // 
            // basicTheme
            // 
            this.basicTheme.Name = "basicTheme";
            this.basicTheme.Size = new System.Drawing.Size(194, 30);
            this.basicTheme.Text = "Basic";
            this.basicTheme.Click += new System.EventHandler(this.basicTheme_Click);
            // 
            // hypnoToad
            // 
            this.hypnoToad.Name = "hypnoToad";
            this.hypnoToad.Size = new System.Drawing.Size(194, 30);
            this.hypnoToad.Text = "Hypno Toad";
            this.hypnoToad.Click += new System.EventHandler(this.hypnoToad_Click);
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
            this.timeBox1.Location = new System.Drawing.Point(12, 445);
            this.timeBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeBox1.Name = "timeBox1";
            this.timeBox1.Size = new System.Drawing.Size(148, 19);
            this.timeBox1.TabIndex = 11;
            // 
            // timeBox2
            // 
            this.timeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox2.Location = new System.Drawing.Point(684, 445);
            this.timeBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeBox2.Name = "timeBox2";
            this.timeBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeBox2.Size = new System.Drawing.Size(148, 19);
            this.timeBox2.TabIndex = 12;
            this.timeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volumeup
            // 
            this.volumeup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeup.AutoSize = true;
            this.volumeup.Image = ((System.Drawing.Image)(resources.GetObject("volumeup.Image")));
            this.volumeup.Location = new System.Drawing.Point(704, 503);
            this.volumeup.Margin = new System.Windows.Forms.Padding(0);
            this.volumeup.Name = "volumeup";
            this.volumeup.Size = new System.Drawing.Size(128, 128);
            this.volumeup.TabIndex = 9;
            this.volumeup.UseVisualStyleBackColor = true;
            this.volumeup.Click += new System.EventHandler(this.volumeup_Click);
            // 
            // volumedown
            // 
            this.volumedown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumedown.AutoSize = true;
            this.volumedown.Image = ((System.Drawing.Image)(resources.GetObject("volumedown.Image")));
            this.volumedown.Location = new System.Drawing.Point(566, 503);
            this.volumedown.Margin = new System.Windows.Forms.Padding(0);
            this.volumedown.Name = "volumedown";
            this.volumedown.Size = new System.Drawing.Size(128, 128);
            this.volumedown.TabIndex = 8;
            this.volumedown.UseVisualStyleBackColor = true;
            this.volumedown.Click += new System.EventHandler(this.volumedown_Click);
            // 
            // skipback
            // 
            this.skipback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipback.AutoSize = true;
            this.skipback.Image = ((System.Drawing.Image)(resources.GetObject("skipback.Image")));
            this.skipback.Location = new System.Drawing.Point(14, 503);
            this.skipback.Margin = new System.Windows.Forms.Padding(0);
            this.skipback.Name = "skipback";
            this.skipback.Size = new System.Drawing.Size(128, 128);
            this.skipback.TabIndex = 6;
            this.skipback.UseVisualStyleBackColor = true;
            this.skipback.Click += new System.EventHandler(this.skipback_Click);
            // 
            // skipforward
            // 
            this.skipforward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipforward.AutoSize = true;
            this.skipforward.Image = ((System.Drawing.Image)(resources.GetObject("skipforward.Image")));
            this.skipforward.Location = new System.Drawing.Point(428, 503);
            this.skipforward.Margin = new System.Windows.Forms.Padding(0);
            this.skipforward.Name = "skipforward";
            this.skipforward.Size = new System.Drawing.Size(128, 128);
            this.skipforward.TabIndex = 3;
            this.skipforward.UseVisualStyleBackColor = true;
            this.skipforward.Click += new System.EventHandler(this.skipforward_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.AutoSize = true;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(290, 503);
            this.pause.Margin = new System.Windows.Forms.Padding(0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(128, 128);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.AutoSize = true;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(152, 503);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(128, 128);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HMM_P3.Properties.Resources.cougtiled3;
            this.pictureBox1.Location = new System.Drawing.Point(443, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 649);
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
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HMM P3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem basicTheme;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hypnoToad;
    }
}

