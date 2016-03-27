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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog fileopener = new OpenFileDialog();
            string filename;
        //    wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_PlayStateChange);


            fileopener.ShowDialog();

            filename = fileopener.FileName;
            wmp = new WindowsMediaPlayer();
            wmp.URL = filename;
            wmp.controls.play();
            ContainerVisual vis = new ContainerVisual();
            vis.VisualXSnappingGuidelines = 10;
            vis.VisualYSnappingGuidelines = 10;
        }

        private void play_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
        }

        private void rewind_Click(object sender, EventArgs e)
        {

        }

        private void forward_Click(object sender, EventArgs e)
        {

        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch(e.newState)
            {
//                case 0:
                    
            }
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
            {
                wmp.URL = m_playlist.prevSong;
                wmp.controls.play();
                songtitleTextBox.value = m_playlist.getSongName();// This is totally not the correct name
            }
            */

        }

        private void skipforward_Click(object sender, EventArgs e)
        {
            wmp.URL = m_playlist.nextSong();
            wmp.controls.play();
            //SongtitleTextBox.Value = m_playlist.getSongName();// This is totally not the correct name

        }

        private void volumedown_Click(object sender, EventArgs e)
        {

        }

        private void volumeup_Click(object sender, EventArgs e)
        {

        }

        private void WMPTest()
        {
            //Windows
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = "C:\\Users\\Matthew\\Source\\Repos\\mark-is-a-hakr\\HMM P3\\62 - A_Rival - Crypt of the Necrodancer OST - Deep Sea Bass (Coral Riff Remix).mp3";
            wmp.controls.play();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            progressBar.Increment(5);
            
        }
    }
}
