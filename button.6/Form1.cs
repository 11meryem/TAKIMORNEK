using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfener_Click(object sender, EventArgs e)
        {
            label1.Text = "FENERBAHÇE";
            label1.BackColor = Color.DarkBlue;
            label1.ForeColor = Color.Yellow;

        }

        private void btntrab_Click(object sender, EventArgs e)
        {
            label1.Text = "TRABZONSPOR";
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Blue;

        }

        private void btnbesik_Click(object sender, EventArgs e)
        {
            label1.Text = "BEŞİKTAŞ";
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;

        }

        private void btngalat_Click(object sender, EventArgs e)
        {
            label1.Text = "GALATASARAY";
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Red;

        }
    }
}
