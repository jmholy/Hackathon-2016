using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMM_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                Button play = new Button();
                Button pause = new Button();
                Button forward = new Button();
                Button reverse = new Button();
                Button skipback = new Button();
                Button skipforward = new Button();

                play.Location = new Point(20, 30*i+10);
                this.Controls.Add(play);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
