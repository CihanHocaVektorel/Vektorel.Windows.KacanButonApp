using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.VeriTasimaApp
{
    public partial class Form2 : Form
    {
       private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           form1.Text = textBox1.Text;
        }
    }
}
