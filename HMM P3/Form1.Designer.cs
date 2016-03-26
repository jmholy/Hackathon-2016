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
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.skipforward = new System.Windows.Forms.Button();
            this.skipback = new System.Windows.Forms.Button();
            this.volumedown = new System.Windows.Forms.Button();
            this.volumeup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play.AutoSize = true;
            this.play.Image = global::HMM_P3.Properties.Resources.PlayButton;
            this.play.Location = new System.Drawing.Point(99, 325);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(89, 87);
            this.play.TabIndex = 1;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pause.AutoSize = true;
            this.pause.Image = global::HMM_P3.Properties.Resources.PauseButton;
            this.pause.Location = new System.Drawing.Point(191, 325);
            this.pause.Margin = new System.Windows.Forms.Padding(0);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(89, 87);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // skipforward
            // 
            this.skipforward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipforward.AutoSize = true;
            this.skipforward.Image = global::HMM_P3.Properties.Resources.SkipForwardButton;
            this.skipforward.Location = new System.Drawing.Point(283, 325);
            this.skipforward.Margin = new System.Windows.Forms.Padding(0);
            this.skipforward.Name = "skipforward";
            this.skipforward.Size = new System.Drawing.Size(89, 87);
            this.skipforward.TabIndex = 3;
            this.skipforward.UseVisualStyleBackColor = true;
            this.skipforward.Click += new System.EventHandler(this.skipforward_Click);
            // 
            // skipback
            // 
            this.skipback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipback.AutoSize = true;
            this.skipback.Image = global::HMM_P3.Properties.Resources.SkipBackButton;
            this.skipback.Location = new System.Drawing.Point(7, 325);
            this.skipback.Margin = new System.Windows.Forms.Padding(0);
            this.skipback.Name = "skipback";
            this.skipback.Size = new System.Drawing.Size(89, 87);
            this.skipback.TabIndex = 6;
            this.skipback.UseVisualStyleBackColor = true;
            this.skipback.Click += new System.EventHandler(this.skipback_Click);
            // 
            // volumedown
            // 
            this.volumedown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumedown.AutoSize = true;
            this.volumedown.Image = global::HMM_P3.Properties.Resources.VolumeDownButton;
            this.volumedown.Location = new System.Drawing.Point(375, 325);
            this.volumedown.Margin = new System.Windows.Forms.Padding(0);
            this.volumedown.Name = "volumedown";
            this.volumedown.Size = new System.Drawing.Size(89, 87);
            this.volumedown.TabIndex = 8;
            this.volumedown.UseVisualStyleBackColor = true;
            this.volumedown.Click += new System.EventHandler(this.volumedown_Click);
            // 
            // volumeup
            // 
            this.volumeup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeup.AutoSize = true;
            this.volumeup.Image = global::HMM_P3.Properties.Resources.VolumeUpButton;
            this.volumeup.Location = new System.Drawing.Point(467, 325);
            this.volumeup.Margin = new System.Windows.Forms.Padding(0);
            this.volumeup.Name = "volumeup";
            this.volumeup.Size = new System.Drawing.Size(89, 87);
            this.volumeup.TabIndex = 9;
            this.volumeup.UseVisualStyleBackColor = true;
            this.volumeup.Click += new System.EventHandler(this.volumeup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 434);
            this.Controls.Add(this.volumeup);
            this.Controls.Add(this.volumedown);
            this.Controls.Add(this.skipback);
            this.Controls.Add(this.skipforward);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

