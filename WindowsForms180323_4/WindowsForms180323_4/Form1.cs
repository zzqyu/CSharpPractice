using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180323_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            tmrClock.Start();
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            tmrClock.Stop();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = (int.Parse(lblDisplay.Text) + 1).ToString();
        }
    }
}
