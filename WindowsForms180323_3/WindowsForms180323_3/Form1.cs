using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180323_3
{
    public partial class Form1 : Form
    {
        public enum ComboBoxParseCase
        {
            None,
            Year,
            Month,
            Day,
            Combine
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            for (int i = localDate.Year - 1000; i <= localDate.Year + 1000; i++) cmbYear.Items.Add(i);
            cmbYear.SelectedI
        }
        private void cmb_ItemOrTextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
