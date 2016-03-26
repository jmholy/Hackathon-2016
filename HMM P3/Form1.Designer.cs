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
            this.play.Location = new System.Drawing.Point(174, 406);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(159, 29);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(337, 406);
            this.pause.Margin = new System.Windows.Forms.Padding(2);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(159, 29);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // skipforward
            // 
            this.skipforward.Location = new System.Drawing.Point(174, 439);
            this.skipforward.Margin = new System.Windows.Forms.Padding(2);
            this.skipforward.Name = "skipforward";
            this.skipforward.Size = new System.Drawing.Size(159, 29);
            this.skipforward.TabIndex = 3;
            this.skipforward.Text = "Skip Forward";
            this.skipforward.UseVisualStyleBackColor = true;
            this.skipforward.Click += new System.EventHandler(this.skipforward_Click);
            // 
            // skipback
            // 
            this.skipback.Location = new System.Drawing.Point(11, 439);
            this.skipback.Margin = new System.Windows.Forms.Padding(2);
            this.skipback.Name = "skipback";
            this.skipback.Size = new System.Drawing.Size(159, 29);
            this.skipback.TabIndex = 6;
            this.skipback.Text = "Skip Back";
            this.skipback.UseVisualStyleBackColor = true;
            this.skipback.Click += new System.EventHandler(this.skipback_Click);
            // 
            // volumedown
            // 
            this.volumedown.Location = new System.Drawing.Point(337, 439);
            this.volumedown.Margin = new System.Windows.Forms.Padding(2);
            this.volumedown.Name = "volumedown";
            this.volumedown.Size = new System.Drawing.Size(159, 29);
            this.volumedown.TabIndex = 8;
            this.volumedown.Text = "Volume Down";
            this.volumedown.UseVisualStyleBackColor = true;
            this.volumedown.Click += new System.EventHandler(this.volumedown_Click);
            // 
            // volumeup
            // 
            this.volumeup.Location = new System.Drawing.Point(500, 439);
            this.volumeup.Margin = new System.Windows.Forms.Padding(2);
            this.volumeup.Name = "volumeup";
            this.volumeup.Size = new System.Drawing.Size(159, 29);
            this.volumeup.TabIndex = 9;
            this.volumeup.Text = "Volume Up";
            this.volumeup.UseVisualStyleBackColor = true;
            this.volumeup.Click += new System.EventHandler(this.volumeup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 479);
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

