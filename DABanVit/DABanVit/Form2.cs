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
        private int live1 = 0;
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
            #region chạy hành tinh
            if (Numrd == 0)
            {
                SaoHoa.Hide();
                TraiDat.Hide();
                SaoKim.Hide();
                Numrd += 1;
            }
            TraiDat.Show();
            Man1.Controls.Add(TraiDat);
            TraiDat.Location = new Point(TraiDat.Location.X, TraiDat.Location.Y + 1);
            if (TraiDat.Location.Y > 890)
            {
                SaoHoa.Show();
                SaoHoa.Location = new Point(SaoHoa.Location.X, SaoHoa.Location.Y);
                Man1.Controls.Add(SaoHoa);
                SaoHoa.Location = new Point(SaoHoa.Location.X, SaoHoa.Location.Y + 1);
            }
            if (SaoHoa.Location.Y > 890)
            {
                SaoKim.Show();
                SaoKim.Location = new Point(SaoKim.Location.X, SaoKim.Location.Y);
                Man1.Controls.Add(SaoKim);
                SaoKim.Location = new Point(SaoKim.Location.X, SaoKim.Location.Y + 1);
            }
            #endregion 
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
            Random rd = new Random();
            n = rd.Next(0, 6);
            #region tạo ngôi sao
            Man1.Controls.Add(Ngoisao);
            Ngoisao.Location = new Point(Ngoisao.Location.X, Ngoisao.Location.Y + n);
            if (Ngoisao.Location.Y > 890)
            {
                Ngoisao.Location = new Point(Ngoisao.Location.X, 0);
            }
            Man1.Controls.Add(Ngoisao1);
            Ngoisao1.Location = new Point(Ngoisao1.Location.X, Ngoisao1.Location.Y + n);
            if (Ngoisao1.Location.Y > 890)
            {
                Ngoisao1.Location = new Point(Ngoisao1.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao2);
            Ngoisao2.Location = new Point(Ngoisao2.Location.X, Ngoisao2.Location.Y + n);
            if (Ngoisao2.Location.Y > 890)
            {
                Ngoisao2.Location = new Point(Ngoisao2.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao3);
            Ngoisao3.Location = new Point(Ngoisao3.Location.X, Ngoisao3.Location.Y + n);
            if (Ngoisao3.Location.Y > 890)
            {
                Ngoisao3.Location = new Point(Ngoisao2.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao4);
            Ngoisao4.Location = new Point(Ngoisao4.Location.X, Ngoisao4.Location.Y + n);
            if (Ngoisao4.Location.Y > 890)
            {
                Ngoisao4.Location = new Point(Ngoisao4.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao5);
            Ngoisao5.Location = new Point(Ngoisao5.Location.X, Ngoisao5.Location.Y + n);
            if (Ngoisao5.Location.Y > 890)
            {
                Ngoisao5.Location = new Point(Ngoisao5.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao6);
            Ngoisao6.Location = new Point(Ngoisao6.Location.X, Ngoisao6.Location.Y + n);
            if (Ngoisao6.Location.Y > 890)
            {
                Ngoisao6.Location = new Point(Ngoisao6.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao7);
            Ngoisao7.Location = new Point(Ngoisao7.Location.X, Ngoisao7.Location.Y + n);
            if (Ngoisao7.Location.Y > 890)
            {
                Ngoisao7.Location = new Point(Ngoisao7.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao8);
            Ngoisao8.Location = new Point(Ngoisao8.Location.X, Ngoisao8.Location.Y + n);
            if (Ngoisao8.Location.Y > 890)
            {
                Ngoisao8.Location = new Point(Ngoisao8.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao9);
            Ngoisao9.Location = new Point(Ngoisao9.Location.X, Ngoisao9.Location.Y + n);
            if (Ngoisao5.Location.Y > 890)
            {
                Ngoisao9.Location = new Point(Ngoisao9.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao10);
            Ngoisao10.Location = new Point(Ngoisao10.Location.X, Ngoisao10.Location.Y + n);
            if (Ngoisao10.Location.Y > 890)
            {
                Ngoisao10.Location = new Point(Ngoisao10.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao11);
            Ngoisao11.Location = new Point(Ngoisao11.Location.X, Ngoisao11.Location.Y + n);
            if (Ngoisao11.Location.Y > 890)
            {
                Ngoisao11.Location = new Point(Ngoisao11.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao12);
            Ngoisao12.Location = new Point(Ngoisao12.Location.X, Ngoisao12.Location.Y + n);
            if (Ngoisao12.Location.Y > 890)
            {
                Ngoisao12.Location = new Point(Ngoisao12.Location.X, 0);

            }
            Man1.Controls.Add(Ngoisao13);
            Ngoisao13.Location = new Point(Ngoisao13.Location.X, Ngoisao13.Location.Y + n);
            if (Ngoisao13.Location.Y > 890)
            {
                Ngoisao13.Location = new Point(Ngoisao13.Location.X, 0);

            }
            #endregion
            
        }
        private void makeDuck()
        {
            //PictureBox Duck = new PictureBox();
            //Duck.BackColor = System.Drawing.Color.White;
            //Duck.Image = "@Resources";
            //Duck.Height = 190;
            //Duck.Width = 91;
            //Duck.Left = (SpaceShip.Left + SpaceShip.Right) / 2;
            //Duck.Top = SpaceShip.Top;
            //Duck.Tag = "duck";
            //Man1.Controls.Add(Duck);
        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = System.Drawing.Color.White;
            bullet.Height = 20;
            bullet.Width = 10;
            bullet.Left = (SpaceShip.Left + SpaceShip.Right)/2;
            bullet.Top = SpaceShip.Top;
            bullet.Tag = "bullet";
            Man1.Controls.Add(bullet);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Man1_MouseMove(object sender, MouseEventArgs e)
        {
            SpaceShip.Left = e.X;
            SpaceShip.Top = e.Y;
        }


        private void Man1_MouseDown(object sender, MouseEventArgs e)
        {
            shot = true;
        }

        private void Man1_MouseUp(object sender, MouseEventArgs e)
        {
            shot = false;
        }
        private int i = 0;
        private void timerBullet_Tick(object sender, EventArgs e)
        {
            if (shot == true)
            {
                if ((i % 1) == 0)
                {
                    makeBullet();
                    
                }
                i++;
            }
            foreach (Control X in Man1.Controls)
            {
                if (X is PictureBox && X.Tag == "bullet")
                {
                    X.Top -= 20;
                    if (X.Top < 0)
                    {
                        Man1.Controls.Remove(X);
                        X.Dispose();
                    }
                }
                #region băn trúng vịt vịt biến mất
                if (X.Bounds.IntersectsWith(pictureBox2.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    live1 += 1;
                    if (live1 == 10)
                    {
                        Man1.Controls.Remove(pictureBox2);
                        pictureBox2.Dispose();
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20);
                        Man1.Controls.Remove(X);
                        X.Dispose();
                    }
                }
                if (X.Bounds.IntersectsWith(pictureBox3.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox3);
                    pictureBox3.Dispose();
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();

                }
                if (X.Bounds.IntersectsWith(pictureBox4.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox4);
                    pictureBox4.Dispose();
                    pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox5.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox5);
                    pictureBox5.Dispose();
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox6.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox6);
                    pictureBox6.Dispose();
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox7.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox7);
                    pictureBox7.Dispose();
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox8.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox8);
                    pictureBox8.Dispose();
                    pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox9.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox9);
                    pictureBox9.Dispose();
                    pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox10.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox10);
                    pictureBox10.Dispose();
                    pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox11.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox11);
                    pictureBox11.Dispose();
                    pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox12.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox12);
                    pictureBox12.Dispose();
                    pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox13.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox13);
                    pictureBox13.Dispose();
                    pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox14.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox14);
                    pictureBox14.Dispose();
                    pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox15.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox15);
                    pictureBox15.Dispose();
                    pictureBox15.Location = new Point(pictureBox19.Location.X, pictureBox15.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox16.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox16);
                    pictureBox16.Dispose();
                    pictureBox16.Location = new Point(pictureBox16.Location.X, pictureBox16.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox17.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox17);
                    pictureBox17.Dispose();
                    pictureBox17.Location = new Point(pictureBox19.Location.X, pictureBox17.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox18.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox18);
                    pictureBox18.Dispose();
                    pictureBox18.Location = new Point(pictureBox19.Location.X, pictureBox18.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                if (X.Bounds.IntersectsWith(pictureBox19.Bounds) && X.Tag == "bullet")
                {
                    score += 1;
                    Man1.Controls.Remove(pictureBox19);
                    pictureBox19.Dispose();
                    pictureBox19.Location = new Point(pictureBox19.Location.X , pictureBox19.Location.Y - 20);
                    Man1.Controls.Remove(X);
                    X.Dispose();
                }
                #endregion
            }


        }

        private void SpaceShip_MouseDown(object sender, MouseEventArgs e)
        {
            shot = true;
        }

        private void SpaceShip_MouseUp(object sender, MouseEventArgs e)
        {
            shot = false;
        }
    }
}
