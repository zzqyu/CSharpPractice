using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180330_2
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
            txtPictiuecmt.Text = "I♡U IU!";
        }

        private void rdoPicture2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.의진;
            txtPictiuecmt.Text = "소나무 의진!";

        }

        private void rdoPicture3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.보나;
            txtPictiuecmt.Text = "우주소녀 보나!";


        }

        private void bntComment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# 재미있죠? ^o^");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntDisplay_Click(object sender, EventArgs e)
        {
            //
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtPictiuecmt.Text = "";

        }
    }
}
