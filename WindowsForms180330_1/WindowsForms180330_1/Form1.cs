using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180330_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
                pictureBox1.Visible = false;
            else
                pictureBox1.Visible = true;

        }

        private void rdoPicture1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.아이유;
        }

        private void rdoPicture2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.의진;
        }

        private void rdoPicture3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.보나;

        }
    }
}
