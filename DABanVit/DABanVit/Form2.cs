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
        #region biến chạy hàng vịt 1
        private int i2 = 10;
        private int i3 = 10;
        private int i4 = 10;
        private int i5 = 10;
        private int i6 = 10;
        private int i7 = 10;
        #endregion
        #region biến chạy hàng vịt 2
        private int i8 = 7;
        private int i9 = 7;
        private int i10 = 7;
        private int i11 = 7;
        private int i12 = 7;
        private int i13 = 7;
        #endregion
        #region biến chạy hàng vịt 2
        private int i14 = 4;
        private int i15 = 4;
        private int i16 = 4;
        private int i17 = 4;
        private int i18 = 4;
        private int i19 = 4;
        #endregion
        #region biến chạy ngôi sao
        private int n = 0;
        private int Numrd=0;
        #endregion
        private void gametime_Tick(object sender, EventArgs e)
        {
            #region hàng vịt 1
            pictureBox2.Location = new Point(pictureBox2.Location.X + i2, pictureBox2.Location.Y);
            if (pictureBox2.Location.X > 1400 || pictureBox2.Location.X <= 0)
            {
                i2 = -i2;
            }

            pictureBox3.Location = new Point(pictureBox3.Location.X + i3, pictureBox3.Location.Y);
            if (pictureBox3.Location.X > 1400 || pictureBox3.Location.X <= 0)
            {
                i3 = -i3;
            }
            pictureBox4.Location = new Point(pictureBox4.Location.X + i4, pictureBox4.Location.Y);
            if (pictureBox4.Location.X > 1400 || pictureBox4.Location.X <= 0)
            {
                i4 = -i4;
            }
            pictureBox5.Location = new Point(pictureBox5.Location.X + i5, pictureBox5.Location.Y);
            if (pictureBox5.Location.X > 1400 || pictureBox5.Location.X <= 0)
            {
                i5 = -i5;
            }
            pictureBox6.Location = new Point(pictureBox6.Location.X + i6, pictureBox6.Location.Y);
            if (pictureBox6.Location.X > 1400 || pictureBox6.Location.X <= 0)
            {
                i6 = -i6;
            }
            pictureBox7.Location = new Point(pictureBox7.Location.X + i7, pictureBox7.Location.Y);
            if (pictureBox7.Location.X > 1400 || pictureBox7.Location.X <= 0)
            {
                i7 = -i7;
            }
            #endregion
            #region hàng vịt 2
            pictureBox8.Location = new Point(pictureBox8.Location.X - i8, pictureBox8.Location.Y);
            if (pictureBox8.Location.X > 1400 || pictureBox8.Location.X <= 0)
            {
                i8 = -i8;
            }

            pictureBox9.Location = new Point(pictureBox9.Location.X - i9, pictureBox9.Location.Y);
            if (pictureBox9.Location.X > 1400 || pictureBox9.Location.X <= 0)
            {
                i9 = -i9;
            }
            pictureBox10.Location = new Point(pictureBox10.Location.X - i10, pictureBox10.Location.Y);
            if (pictureBox10.Location.X > 1400 || pictureBox10.Location.X <= 0)
            {
                i10 = -i10;
            }
            pictureBox11.Location = new Point(pictureBox11.Location.X - i11, pictureBox11.Location.Y);
            if (pictureBox11.Location.X > 1400 || pictureBox11.Location.X <= 0)
            {
                i11 = -i11;
            }
            pictureBox12.Location = new Point(pictureBox12.Location.X - i12, pictureBox12.Location.Y);
            if (pictureBox12.Location.X > 1400 || pictureBox12.Location.X <= 0)
            {
                i12 = -i12;
            }
            pictureBox13.Location = new Point(pictureBox13.Location.X - i13, pictureBox13.Location.Y);
            if (pictureBox13.Location.X > 1400 || pictureBox13.Location.X <= 0)
            {
                i13 = -i13;
            }
            #endregion
            #region hàng vịt 3
            pictureBox14.Location = new Point(pictureBox14.Location.X + i14, pictureBox14.Location.Y);
            if (pictureBox14.Location.X > 1400 || pictureBox14.Location.X <= 0)
            {
                i14 = -i14;
            }

            pictureBox15.Location = new Point(pictureBox15.Location.X + i15, pictureBox15.Location.Y);
            if (pictureBox15.Location.X > 1400 || pictureBox15.Location.X <= 0)
            {
                i15 = -i15;
            }
            pictureBox16.Location = new Point(pictureBox16.Location.X + i16, pictureBox16.Location.Y);
            if (pictureBox16.Location.X > 1400 || pictureBox16.Location.X <= 0)
            {
                i16 = -i16;
            }
            pictureBox17.Location = new Point(pictureBox17.Location.X - i17, pictureBox17.Location.Y);
            if (pictureBox17.Location.X > 1400 || pictureBox17.Location.X <= 0)
            {
                i17 = -i17;
            }
            pictureBox18.Location = new Point(pictureBox18.Location.X - i18, pictureBox18.Location.Y);
            if (pictureBox18.Location.X > 1400 || pictureBox18.Location.X <= 0)
            {
                i18 = -i18;
            }
            pictureBox19.Location = new Point(pictureBox19.Location.X - i19, pictureBox19.Location.Y);
            if (pictureBox19.Location.X > 1400 || pictureBox19.Location.X <= 0)
            {
                i19 = -i19;
            }
            #endregion
            //foreach(Control X in this.Controls)
            //{
            //    Ngoisao.Left = 50;
            //    Ngoisao.Top = rand.Next(0, 1000);

            //}
            Random rd = new Random();
            n = rd.Next(0, 11);
            #region tạo ngôi sao
            Ngoisao.Location = new Point(Ngoisao.Location.X, Ngoisao.Location.Y + n);
            if(Ngoisao.Location.Y > 890)
            {
                Ngoisao.Location = new Point(Ngoisao.Location.X, 0);
                
            }
            Ngoisao1.Location = new Point(Ngoisao1.Location.X, Ngoisao1.Location.Y + n);
            if (Ngoisao1.Location.Y > 890)
            {
                Ngoisao1.Location = new Point(Ngoisao1.Location.X, 0);
                
            }
            Ngoisao2.Location = new Point(Ngoisao2.Location.X, Ngoisao2.Location.Y + n);
            if (Ngoisao2.Location.Y > 890)
            {
                Ngoisao2.Location = new Point(Ngoisao2.Location.X, 0);
                
            }
            Ngoisao3.Location = new Point(Ngoisao3.Location.X, Ngoisao3.Location.Y + n);
            if (Ngoisao3.Location.Y > 890)
            {
                Ngoisao3.Location = new Point(Ngoisao2.Location.X, 0);

            }
            Ngoisao4.Location = new Point(Ngoisao4.Location.X, Ngoisao4.Location.Y + n);
            if (Ngoisao4.Location.Y > 890)
            {
                Ngoisao4.Location = new Point(Ngoisao4.Location.X, 0);

            }
            Ngoisao5.Location = new Point(Ngoisao5.Location.X, Ngoisao5.Location.Y + n);
            if (Ngoisao5.Location.Y > 890)
            {
                Ngoisao5.Location = new Point(Ngoisao5.Location.X, 0);

            }
            #endregion
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
    }
}
