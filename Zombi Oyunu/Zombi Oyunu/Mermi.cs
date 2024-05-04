using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Zombi_Oyunu
{
    public class Mermi
    {
        public string bakis;
        public int konumX, konumY;

        private Timer mermiTimer = new Timer();
        private PictureBox mermi = new PictureBox();
        private int mermi_hiz = 20;

        public Mermi(int a, int y, string c)
        {
            konumX = a;
            konumY = y;
            bakis = c;
        }

        public void Mermi_olustur(Form form,int x, int y)
        {
            mermi.Size = new Size(10,10);
            mermi.Image = Properties.Resources.mermi;
            mermi.SizeMode = PictureBoxSizeMode.StretchImage;
            mermi.Location = new Point(x, y);
            mermi.Tag = "mermi";
            form.Controls.Add(mermi);
            mermiTimer.Interval = mermi_hiz;
            mermiTimer.Tick += new EventHandler(MermiTimerEvent);
            mermiTimer.Start();
        }

        private void MermiTimerEvent(object sender , EventArgs e)
        {
            if(bakis == "sag")
            {
                mermi.Left += mermi_hiz;
            }
            else if(bakis == "sol")
            {
                mermi.Left -= mermi_hiz;
            }
            else if(bakis == "yukari")
            {
                mermi.Top -= mermi_hiz;
            }
            else if(bakis == "asagi")
            {
                mermi.Top += mermi_hiz;
            }

            if(mermi.Left < 0 ||mermi.Left > 1200 || mermi.Top < 0 || mermi.Top > 700)
            {
                mermi.Dispose();
                mermiTimer.Stop();
                mermiTimer.Dispose();
                mermi = null;
                mermiTimer = null;
            }

        }

    }
}
