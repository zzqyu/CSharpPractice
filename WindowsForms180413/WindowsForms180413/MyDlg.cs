using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180413
{
    public partial class MyDlg : Form
    {
        public MyDlg()
        {
            InitializeComponent();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
