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
    public partial class NotePadChildForm : Form
    {
        public NotePadChildForm()
        {
            InitializeComponent();
        }
        public TextBox getTextBox()
        {
            return this.textBox1;
        }
    }
}
