using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;
using WMPLib;


namespace HMM_P3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp;
        PlaylistContainer m_playlist;
        int sec1 = 0, sec2 = 0;
        int min1 = 0, min2 = 0;
        int refresh = 0;
        int repeat = 200;
        string[] songList = new String[100];
        int songCount = 1;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayerClass();
            m_playlist = new PlaylistContainer();
            wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(media_PlayStateChange);
            
            timer1.Interval = 1000;
            timeBox1.Text = "0:00";
            timeBox2.Text = "0:00";
            
        }

        private void media_PlayStateChange(int state)
        {
            
            if ((WMPLib.WMPPlayState) state == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                string temp = wmp.URL;
                if (repeat < 2)
                {
                    wmp.URL = m_playlist.nextSong(repeat);
                }
                else
                {
                    wmp.URL = m_playlist.nextSong();
                }
                //wmp.URL = m_playlist.nextSong();
                if (wmp.URL != "")
                {
                    wmp.controls.play();
                    songInfoBox.Text = "Song Title: " + m_playlist.getSongName();
                }
                else
                {
                    wmp.URL = temp;
                    wmp.controls.stop();
                    timer1.Stop();
                    timeBox1.Text = "0:00";
                    timeBox2.Text = "0:00";
                }

                min1 = 0;
                sec1 = 0;
                min2 = 0;
                sec2 = 0;
                progressBar.Value = 0;
            }
            else if ((WMPLib.WMPPlayState)state == WMPLib.WMPPlayState.wmppsStopped)
            {
                timeBox1.Text = "0:00";
                timeBox2.Text = "0:00";
                min1 = 0;
                sec1 = 0;
                min2 = 0;
                sec2 = 0;

                timer1.Stop();
                progressBar.Value = 0;
            }
            else if ((WMPLib.WMPPlayState)state == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if ((WMPLib.WMPPlayState)state == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (wmp.URL != null)
            {
                wmp.controls.pause();
                timer1.Stop();
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (wmp.URL != "")
            {
                timer1.Start();
                wmp.controls.play();
                songInfoBox.Text = "Song Title: " + m_playlist.getSongName();
             }

        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            //progressBar.Increment(5);
        }

        private void skipback_Click(object sender, EventArgs e)
        {
            
            if(sec1 > 5 || min1 > 1)//<-------------- This is totally not the correct name
            {
                wmp.controls.stop();
                wmp.controls.play();
            }
            else
            {
                wmp.controls.stop();
                string temp = wmp.URL;
                if (temp != "")
                {
                    wmp.URL = m_playlist.prevSong();

                    if (wmp.URL != "")
                    {
                        wmp.controls.play();
                        songInfoBox.Text = "Song Title: " + m_playlist.getSongName();
                    }
                    else
                    {
                        wmp.URL = temp;
                        wmp.controls.stop();
                    }
                }
            }
        }

        private void skipforward_Click(object sender, EventArgs e)
        {
            string temp = wmp.URL;

            if (temp != "")
            {
                wmp.controls.stop();
                if (repeat < 2)
                {
                    wmp.URL = m_playlist.nextSong(repeat);
                }
                else
                {
                    wmp.URL = m_playlist.nextSong();
                }
                if (wmp.URL != "")
                {
                    wmp.controls.play();
                    songInfoBox.Text = "Song Title: " + m_playlist.getSongName();
                }
                else
                {
                    wmp.URL = temp;
                    wmp.controls.stop();
                }   
            }
        }

        private void volumedown_Click(object sender, EventArgs e)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void volumeup_Click(object sender, EventArgs e)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int duration = (int)wmp.currentMedia.duration;
            if (refresh == 10)
            {
                webBrowser1.Refresh();
                webBrowser2.Refresh();
                refresh = 0;
            }
            refresh++;
            progressBar.Maximum = ((824 / duration) * duration);
            if (duration != 0)
            {
                progressBar.Increment(824 / duration);
            }
            if (timeBox2.Text == "0:00" && timeBox1.Text == "0:00")
            {
                sec2 = duration % 60;
                min2 = duration / 60;
            }
            if (sec1 == 60)
            {
                min1++;
                sec1 = 0;
            }
            timeBox1.Text = min1 + ":" + sec1.ToString("D2");
            sec1++;
            timeBox2.Text = "-" + min2 + ":" + sec2.ToString("D2");
            if (sec2 == 0)
            {
                min2--;
                sec2 = 60;
            }
            sec2--;
            if (timeBox2.Text == "0:00" && timeBox1.Text == Convert.ToString(duration))
            {
                timer1.Stop();
            }

        }

        private void basicTheme_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cougtiled3;
            songBox.BackColor = System.Drawing.Color.FromArgb(232, 46, 46);
            progressBar.ForeColor = System.Drawing.Color.FromArgb(232, 46, 46);
            repeat = 200;
        }

        private void hypnoToad_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hypnotoad;
            songBox.BackColor = System.Drawing.Color.FromArgb(61, 255, 13);
            progressBar.ForeColor = System.Drawing.Color.FromArgb(61, 255, 13);
            repeat = 200;
        }

        private void addSongsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<string> i;
            OpenFileDialog fileopener = new OpenFileDialog();
            fileopener.Multiselect = true;
            fileopener.ShowDialog();

            foreach (string filename in fileopener.FileNames)
            {
                m_playlist.addSong(filename);
                songCount++;
            }

            i = m_playlist.SongList();
            string listString = String.Empty;
            listString =  "1 - " + i[0] + System.Environment.NewLine;
            for (int k = 1; k < songCount-1; k++)
            {
                listString = listString + (k+1) + " - " + i[k] + System.Environment.NewLine;
            }
            songBox.Text = listString;

            if (wmp.URL == "")
            {
                wmp.URL = m_playlist.getFileName();
                wmp.controls.stop();
            }

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.boring;
            songBox.BackColor = SystemColors.Control;
            progressBar.ForeColor = SystemColors.MenuText;
        }

        private void windows98HELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.windows98;
            songBox.BackColor = System.Drawing.Color.FromArgb(222,222,222);
            progressBar.ForeColor = SystemColors.Highlight;
            m_playlist = new PlaylistContainer();
            //string filename = "C:\\Users\\M\\Source\\Repos\\mark-is-a-hakr3\\HMM P3\\Windows-98-startup-sound.wav";
            //wmp.URL = "C:\\Users\\M\\Source\\Repos\\mark-is-a-hakr3\\HMM P3\\Windows-98-startup-sound.wav";
            //string songName;
            //string songListstring = "\0";
            //int j = 1;
            //string[] temp = filename.Split('\\');
            //songName = temp[temp.Length - 1];
            //temp = songName.Split('.');
            //songName = temp[0];
            //songListstring = songName + System.Environment.NewLine;
            //songBox.Text = songListstring;
            //wmp.controls.play();
            string filename = "C:\\Users\\M\\Source\\Repos\\mark-is-a-hakr3\\HMM P3\\Windows-98-startup-sound.wav";
            m_playlist.addSong(filename);
            songBox.Text = m_playlist.getSongName(); 
            wmp.URL = m_playlist.getFileName();
        }

    }
}
