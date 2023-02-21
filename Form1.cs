using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text= "OK";
            btn.AutoSize= true;
            Random rand= new Random();
            btn.Location = new Point(rand.Next(0,pnlButton.Size.Width),rand.Next(0,pnlButton.Size.Height));
            MessageBox.Show("ddddd");
            MessageBox.Shhow("aaaa");
            pnlButton.Controls.Add(btn);
            fpnlButton.Controls.Add(btn);
        }
    }
}
