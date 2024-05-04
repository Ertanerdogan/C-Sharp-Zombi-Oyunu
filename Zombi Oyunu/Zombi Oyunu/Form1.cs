using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Zombi_Oyunu
{
    public partial class Form1 : Form
    {
        // KARAKTER BOYUTU 
        // X = 73 , Y = 90  ( ADAM YUKARI - AŞAĞI BAKIYORSA )
        // X = 90 , Y = 73 ( ADAM SAĞA - SOLA BAKIYORSA )

        // ZOMBİ BOYUTU
        // X = 60 , Y = 60

        // MERMİ SPAWN HESABI
        // ADAMIN YÖNÜ SAĞ İSE          X + 94 , Y + 49
        // ADAMIN YÖNÜ SOL İSE          X - 16 , Y + 12
        // ADAMIN YÖNÜ YUKARI İSE       X + 49 , Y - 21
        // ADAMIN YÖNÜ AŞAĞI İSE  310 97 324 209

        List<PictureBox> zombiler = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
        }

 
        
        int mermi_sayisi = 10;
        int can = 100;
        bool hareket = true;
        public string yon;
        int skor = 0;
        int infoX;
        int infoY;
        private void Form1_Load(object sender, EventArgs e)
        {
            infoX = karakter.Location.X;
            infoY = karakter.Location.Y;
            this.Size = new Size(1100, 600);
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
            LblMermi.Text = "Mermi : " + mermi_sayisi;
            for(int i = 0;i<5;i++)
            {
                PictureBox zombi = new PictureBox();
                zombi.Size = new Size(50, 50);
                zombi.SizeMode = PictureBoxSizeMode.StretchImage;
                zombi.Location = new Point(0, 0);
                zombi.Image = Properties.Resources.zombi_sag;
                zombi.Tag = "zombi";
                zombiler.Add(zombi);
            }
            foreach(PictureBox zombi in zombiler)
            {
                this.Controls.Add(zombi);
            }
            zombiler[0].Location = new Point(300, 300);
            zombiler[1].Location = new Point(800, 200);
            zombiler[2].Location = new Point(100, 100);
            zombiler[3].Location = new Point(0, 0);
            zombiler[4].Location = new Point(1050, 550);
        }

        private void zombi_hareket()
        {
            foreach(PictureBox zombi in zombiler)
            {
                int a = karakter.Location.X - 35;
                int b = karakter.Location.X + 35;
                if (zombi.Location.X < karakter.Location.X)
                {
                    if(zombi.Location.X < b && zombi.Location.X >= a)
                    {
                        if(zombi.Location.Y < karakter.Location.Y)
                        {
                            
                            zombi.Image = Properties.Resources.zombi_asagi;
                            zombi.Top += 2;
                            
                        }
                        else
                        {
                            zombi.Image = Properties.Resources.zombi_yukari;
                            zombi.Top -= 2;
                        }
                        
                    }
                    else
                    {
                        zombi.Image = Properties.Resources.zombi_sag;
                        zombi.Left += 2;
                    }
                }
                else
                {
                    zombi.Image = Properties.Resources.zombi_sol;
                    zombi.Left -= 2;
                }
            }
        }

        private void mermi_hediye()
        {
            PictureBox hediye = new PictureBox();
            hediye.Size = new Size(50, 50);
            hediye.Image = Properties.Resources.hediye;
            hediye.Tag = "hediye";
            Random a = new Random();
            Random b = new Random();
            hediye.Location = new Point(a.Next(0, 1000), b.Next(0, 500));
            hediye.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(hediye);
        }
        
        private void can_hediye()
        {
            PictureBox can = new PictureBox();
            can.Size = new Size(60, 50);
            can.SizeMode = PictureBoxSizeMode.StretchImage;
            can.Image = Properties.Resources.can;
            can.Tag = "can";
            Random a = new Random();
            Random b = new Random();
            can.Location = new Point(a.Next(0, 1000), b.Next(0, 500));
            this.Controls.Add((can));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                karakter.Image = Properties.Resources.adam_yukari;
                karakter.Size = new Size(73, 90);
                hareket = true;
                yon = "yukari";
            }
            else if (e.KeyCode == Keys.S)
            {
                karakter.Image = Properties.Resources.adam_asagi;
                karakter.Size = new Size(73, 90);
                hareket = true;
                yon = "asagi";
            }
            else if (e.KeyCode == Keys.D)
            {
                karakter.Image = Properties.Resources.adam_sag;
                karakter.Size = new Size(90, 73);
                hareket = true;
                yon = "sag";
            }
            else if (e.KeyCode == Keys.A)
            {
                karakter.Image = Properties.Resources.adam_sol;
                karakter.Size = new Size(90, 73);
                hareket = true;
                yon = "sol";
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                hareket = false;
            }
            else if(e.KeyCode == Keys.Space)
            {
                if(yon == "sag" && mermi_sayisi >= 1)
                {
                    int x = karakter.Location.X + 94;
                    int y = karakter.Location.Y + 49;
                    Mermi mermi = new Mermi(x, y,yon);
                    mermi.Mermi_olustur(this,x,y);
                    mermi_sayisi--;
                    LblMermi.Text = "MERMİ : " + mermi_sayisi;
                    if (mermi_sayisi == 0)
                    {
                        mermi_hediye();
                    }
                }
                else if(yon == "sol" && mermi_sayisi >= 1)
                {
                    int x = karakter.Location.X - 16;
                    int y = karakter.Location.Y + 12;
                    Mermi mermi = new Mermi(x, y, yon);
                    mermi.Mermi_olustur(this, x, y);
                    mermi_sayisi--;
                    LblMermi.Text = "MERMİ : " + mermi_sayisi;
                    if (mermi_sayisi == 0)
                    {
                        mermi_hediye();
                    }
                }
                else if(yon == "yukari" && mermi_sayisi >= 1)
                {
                    int x = karakter.Location.X + 49;
                    int y = karakter.Location.Y - 21;
                    Mermi mermi = new Mermi(x, y, yon);
                    mermi.Mermi_olustur(this, x, y);
                    mermi_sayisi--;
                    LblMermi.Text = "MERMİ : " + mermi_sayisi;
                    if (mermi_sayisi == 0)
                    {
                        mermi_hediye();
                    }
                }
                else if(yon == "asagi" && mermi_sayisi >= 1)
                {
                    int x = karakter.Location.X + 14;
                    int y = karakter.Location.Y + 100;
                    Mermi mermi = new Mermi(x, y, yon);
                    mermi.Mermi_olustur(this, x, y);
                    mermi_sayisi--;
                    LblMermi.Text = "MERMİ : " + mermi_sayisi;
                    if(mermi_sayisi == 0)
                    {
                        mermi_hediye();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zombi_hareket();
            if(hareket)
            {
                if (yon == "yukari")
                {
                    if(karakter.Top > -40)
                    {
                        karakter.Top -= 10;
                    }
                }
                else if (yon == "asagi")
                {
                    if(karakter.Top < 550)
                    {
                        karakter.Top += 10;
                    }
                }
                else if (yon == "sag")
                {
                    if(karakter.Left < 1050)
                    {
                        karakter.Left += 10;
                    }
                    
                }
                else if (yon == "sol")
                {
                    if(karakter.Left > -60)
                    {
                        karakter.Left -= 10;
                    }
                }
                
            }
            foreach(PictureBox zombi in zombiler)
            {
                if(karakter.Bounds.IntersectsWith(zombi.Bounds))
                {
                    Random a = new Random();
                    Random b = new Random();
                    zombi.Location = new Point(a.Next(0,600), b.Next(0,400));
                    if(progressBar1.Value != 10)
                    {
                        progressBar1.Value -= 10;
                        can -= 10;
                    }
                    else
                    {
                        progressBar1.Value = 0;
                        can = 0;
                        canLabel.Text = "0/100";
                        timer1.Stop();
                        DialogResult tekrar = new DialogResult();
                        tekrar = MessageBox.Show("Tekrar oynamak ister misin ?","Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(tekrar == DialogResult.Yes)
                        {
                            tekrar_oyna();
                        }
                    }
                    canLabel.Text = can + "/100";
                }
            }
            
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "mermi")
                {
                    foreach(PictureBox zombi in zombiler)
                    {
                        if(x.Bounds.IntersectsWith(zombi.Bounds))
                        {
                            x.Dispose();
                            Random a = new Random();
                            Random b = new Random();
                            zombi.Location = new Point(a.Next(0, 1000), b.Next(0, 500));
                            skor++;
                            label3.Text = "SKOR : " + skor;
                            if(skor % 15 == 0)
                            {
                                can_hediye();
                            }
                        }
                    }
                }
                if(x is PictureBox && (string)x.Tag == "hediye")
                {
                    if(karakter.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Dispose();
                        mermi_sayisi += 10;
                        LblMermi.Text = "MERMİ : " + mermi_sayisi;
                    }
                }

                if(x is PictureBox && (string)x.Tag == "can")
                {
                    if (karakter.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Dispose();
                        if(can <= 70)
                        {
                            can += 30;
                            progressBar1.Value += 30;
                            canLabel.Text = can + "/100";
                        }
                        else
                        {
                            can = 100;
                            progressBar1.Value = 100;
                            canLabel.Text = can + "/100";
                        }
                    }
                }
            }
        }

        private void tekrar_oyna()
        {
            mermi_sayisi = 10;
            progressBar1.Value = 100;
            hareket = false;
            can = 100;
            canLabel.Text = can + "/100";
            skor = 0;
            label3.Text = "SKOR : " + skor;
            karakter.Location = new Point(infoX,infoY);
            zombiler[0].Location = new Point(300, 300);
            zombiler[1].Location = new Point(800, 200);
            zombiler[2].Location = new Point(100, 100);
            zombiler[3].Location = new Point(0, 0);
            zombiler[4].Location = new Point(1050, 550);
            timer1.Start();
        }
    }
}
