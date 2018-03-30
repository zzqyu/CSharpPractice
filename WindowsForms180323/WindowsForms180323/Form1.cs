using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font("돋움", txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font("굴림", txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font("궁서", txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Bold ^ txtNote.Font.Style);
            txtNote.Font = f;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
             Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Underline ^ txtNote.Font.Style);
             txtNote.Font = f;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Italic ^ txtNote.Font.Style);
            txtNote.Font = f;
            
        }
    }
}
