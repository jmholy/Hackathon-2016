using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace HMM_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog fileopener = new OpenFileDialog();
            string filename;

            
            fileopener.ShowDialog();

            filename = fileopener.FileName;
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = filename;
            wmp.controls.play();
        }

        private void play_Click(object sender, EventArgs e)
        {
            
        }

        private void pause_Click(object sender, EventArgs e)
        {

        }

        private void rewind_Click(object sender, EventArgs e)
        {

        }

        private void forward_Click(object sender, EventArgs e)
        {

        }

        private void skipback_Click(object sender, EventArgs e)
        {

        }

        private void skipforward_Click(object sender, EventArgs e)
        {
            
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
    }
}
