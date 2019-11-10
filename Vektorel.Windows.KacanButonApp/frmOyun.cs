using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vektorel.UtilityLib;

namespace Vektorel.Windows.KacanButonApp
{
    public partial class frmOyun : Form
    {
        int count = 0;
        int sure = 3;
        List<int> skorlar = new List<int>();
        public frmOyun()
        {
            InitializeComponent();
        }       

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();           
            count++;
            if (count % 10 == 0)
            {
                this.Size = new Size(this.Width + 100, this.Height + 100);
            }
            btnKac.Text = count.ToString();

            btnKac.Location = new Point(rnd.Next(this.ClientSize.Width - btnKac.Width), rnd.Next(this.ClientSize.Height - btnKac.Height));
        }  

        private void TmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            this.Text = sure.ToString();
            if (sure == 0)
            {
                skorlar.Add(count);
                tmrSure.Stop();
                DialogResult cvp = MessageBox.Show($"Süreniz doldu.Puanınız:{count}\nYeniden Oynamak İstiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    sure = 3;
                    count = 0;
                    btnKac.Text = count.ToString();
                    this.Size = new Size(300, 300);
                    tmrSure.Start();
                }
                else
                {
                    int maxscore = MaxScore(skorlar);
                    DosyaIslemleri.DosyaYazdir($"{DateTime.Now} tarihinde en yüksek skorunuz:{maxscore}","skorlar.txt");
                    MessageBox.Show($"Oyun bitti.En yüksek skorunuz:{maxscore}"); 
                    btnKac.Text = ":)";
                    btnKac.Enabled = false;
                }
            }
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrSure.Start();
        }

        int MaxScore(List<int> skorlar)
        {
            int max = 0;
            if (skorlar.Count != 0)
            {
                foreach (int item in skorlar)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
            }
            return max;
        }
    }
}
