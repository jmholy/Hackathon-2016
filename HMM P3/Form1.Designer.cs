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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.skipforward = new System.Windows.Forms.Button();
            this.skipback = new System.Windows.Forms.Button();
            this.volumedown = new System.Windows.Forms.Button();
            this.volumeup = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(148, 500);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(134, 134);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(286, 500);
            this.pause.Margin = new System.Windows.Forms.Padding(0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(134, 134);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // skipforward
            // 
            this.skipforward.AutoSize = true;
            this.skipforward.Image = ((System.Drawing.Image)(resources.GetObject("skipforward.Image")));
            this.skipforward.Location = new System.Drawing.Point(424, 500);
            this.skipforward.Margin = new System.Windows.Forms.Padding(0);
            this.skipforward.Name = "skipforward";
            this.skipforward.Size = new System.Drawing.Size(134, 134);
            this.skipforward.TabIndex = 3;
            this.skipforward.UseVisualStyleBackColor = true;
            this.skipforward.Click += new System.EventHandler(this.skipforward_Click);
            // 
            // skipback
            // 
            this.skipback.AutoSize = true;
            this.skipback.Image = ((System.Drawing.Image)(resources.GetObject("skipback.Image")));
            this.skipback.Location = new System.Drawing.Point(10, 500);
            this.skipback.Margin = new System.Windows.Forms.Padding(0);
            this.skipback.Name = "skipback";
            this.skipback.Size = new System.Drawing.Size(134, 134);
            this.skipback.TabIndex = 6;
            this.skipback.UseVisualStyleBackColor = true;
            this.skipback.Click += new System.EventHandler(this.skipback_Click);
            // 
            // volumedown
            // 
            this.volumedown.AutoSize = true;
            this.volumedown.Image = ((System.Drawing.Image)(resources.GetObject("volumedown.Image")));
            this.volumedown.Location = new System.Drawing.Point(562, 500);
            this.volumedown.Margin = new System.Windows.Forms.Padding(0);
            this.volumedown.Name = "volumedown";
            this.volumedown.Size = new System.Drawing.Size(134, 134);
            this.volumedown.TabIndex = 8;
            this.volumedown.UseVisualStyleBackColor = true;
            this.volumedown.Click += new System.EventHandler(this.volumedown_Click);
            // 
            // volumeup
            // 
            this.volumeup.AutoSize = true;
            this.volumeup.Image = ((System.Drawing.Image)(resources.GetObject("volumeup.Image")));
            this.volumeup.Location = new System.Drawing.Point(700, 500);
            this.volumeup.Margin = new System.Windows.Forms.Padding(0);
            this.volumeup.Name = "volumeup";
            this.volumeup.Size = new System.Drawing.Size(134, 134);
            this.volumeup.TabIndex = 9;
            this.volumeup.UseVisualStyleBackColor = true;
            this.volumeup.Click += new System.EventHandler(this.volumeup_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.progressBar.Location = new System.Drawing.Point(148, 467);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(548, 25);
            this.progressBar.TabIndex = 10;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 649);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.volumeup);
            this.Controls.Add(this.volumedown);
            this.Controls.Add(this.skipback);
            this.Controls.Add(this.skipforward);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Name = "Form1";
            this.Text = "HMM P3";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

