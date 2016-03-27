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
using WMPLib;


namespace HMM_P3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp;
        PlaylistContainer m_playlist;
        int sec1 = 0, sec2 = 0;
        int min1 = 0, min2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp = new WindowsMediaPlayerClass();
            m_playlist = new PlaylistContainer();
            timer1.Interval = 1000;
        }


        private void addSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileopener = new OpenFileDialog();
            fileopener.Multiselect = true;
            fileopener.ShowDialog();

            foreach (string filename in fileopener.FileNames)
            {
                m_playlist.addSong(filename);
            }

            if (wmp.URL == "")
            {
                wmp.URL = m_playlist.getFileName();
            }
            wmp.controls.stop();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
            timer1.Stop();
        }

        private void play_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
            timer1.Start();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            //progressBar.Increment(5);
        }

        private void skipback_Click(object sender, EventArgs e)
        {
            /*
            if(songprogressBar < 5)//<-------------- This is totally not the correct name
            {
                wmp.controls.stop();
                wmp.controls.play();
            }
            else
            {*/
            string temp = m_playlist.getFileName();
            wmp.URL = m_playlist.prevSong();

            if (wmp.URL != "")
            {
                wmp.controls.play();
            }
            else
            {
                wmp.URL = temp;
                wmp.controls.stop();
            }
            //songtitleTextBox.value = m_playlist.getSongName();// This is totally not the correct name
            //}
            //*/

        }

        private void skipforward_Click(object sender, EventArgs e)
        {
            string temp = wmp.URL;

            wmp.URL = m_playlist.nextSong();
            if (wmp.URL != "")
            {
                wmp.controls.play();
            }
            else
            {
                wmp.URL = temp;
                wmp.controls.stop();
            }
            //SongtitleTextBox.Value = m_playlist.getSongName();// This is totally not the correct name

        }

        private void volumedown_Click(object sender, EventArgs e)
        {

        }

        private void volumeup_Click(object sender, EventArgs e)
        {

        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch(e.newState)
            {
//                case 0:
                    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int duration = (int)wmp.currentMedia.duration;
            progressBar.Maximum = 846;
            progressBar.Increment(846 / duration);
            if (timeBox2.Text == "0:00" && timeBox1.Text == "0:00")
            {
                sec2 = duration % 60;
                min2 = duration / 60;
            }
            timeBox1.Text = min1 + ":" + sec1.ToString("D2");
            sec1++;
            if (sec1 == 60)
            {
                min1++;
                sec1 = 0;
            }
            timeBox2.Text = min2 + ":" + sec2.ToString("D2");
            if (sec2 == 0)
            {
                min2--;
                sec2 = 60;
            }
            if (timeBox2.Text == "0:00" && timeBox1.Text == Convert.ToString(duration))
            {
                timer1.Stop();
            }

        }
      }
}
