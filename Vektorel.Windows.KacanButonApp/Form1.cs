using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.KacanButonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            Size s = new Size();
            s.Width = 100;
            s.Height = 30;
            btn.Size = s;
            btn.Text = "Bizim Buton";
            btn.Click += BizimButonClick;
            this.Controls.Add(btn);
        }

        void BizimButonClick(object o, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;

            MessageBox.Show(buton.Text + " Clicklendi");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X.ToString()} Y:{e.Y.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
