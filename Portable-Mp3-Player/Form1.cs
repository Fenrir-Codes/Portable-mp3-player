using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Mp3_Player
{
    public partial class FreeMp3Player : Form
    {
        private Mp3Player Mp3Player = new Mp3Player();

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;


        public FreeMp3Player()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)  // minimize to tray
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpsidePanel_MouseDown(object sender, MouseEventArgs e) // if true drag the window
        {
            mouseDown = true;
        }

        private void UpsidePanel_MouseUp(object sender, MouseEventArgs e) // mouse down false, release the window
        {
            mouseDown = false;
        }

        private void UpsidePanel_MouseMove(object sender, MouseEventArgs e)  // sets the window location
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X  - 250;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   this.filename_box.Text = ofd.FileName.ToString();
                    Mp3Player.open(ofd.FileName);
                }
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            Mp3Player.play();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            Mp3Player.stop();
           
        }

        private void filename_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mp3Player.play();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mp3Player.stop();
        }
    }
}
