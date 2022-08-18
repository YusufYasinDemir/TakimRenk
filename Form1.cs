using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U200920021_TAKIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBeyaz_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void rbMavi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void rbKirmizi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void rbSari_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void rbYeşil_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
