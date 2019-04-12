using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DABanVit
{
    public partial class Form2 : Form
    {
        bool group;
        bool godown;
        bool shot = false;
        int score = 0;
        int speed = 8;
        Random rand = new Random();
        int playerSpeed = 7;
        int index;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                group = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Space && shot == false)
            {
                makeBullet();
                shot = true;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                group = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if(shot == true)
            {
                shot = false;
            }
        }
        private int i = 10;
        private void gametime_Tick(object sender, EventArgs e)
        {
            //pictureBox2.Location = new Point(pictureBox2.Location.X + i, pictureBox2.Location.Y);
            //if(pictureBox2.Location.X > 800 || pictureBox2.Location.X <= 0)
            //{
            //    i = -i;
            //}
            //pictureBox2.Left += speed;
            //if(pictureBox2.Location.Y == 876)
            //{
            //    pictureBox2.Left -= speed;
            //}
            pictureBox2.Left += speed;
            if (pictureBox2.Location.X > 876 || pictureBox2.Location.X < 0)
            {
                pictureBox2.Left -= speed;
                i = -i;
            }


        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = System.Drawing.Color.DarkBlue;
            bullet.Height = 5;
            bullet.Width = 10;
            //bullet.Left = MayBay.Left + MayBay.Width;
            //bullet.Top = MayBay.Top + MayBay.Height;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Man1_MouseMove(object sender, MouseEventArgs e)
        {
            SpaceShip.Left = e.X;
            SpaceShip.Top = e.Y;
        }

        private void GameTime1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
