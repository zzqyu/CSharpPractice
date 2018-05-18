using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_180518
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
            dataSet = new DataSet1();
            dataSet.Tables["Person"].Rows.Add(new object[] { 1, "kim", 30 });
            dataSet.Tables["Person"].Rows.Add(new object[] { 2, "Kong", 35 });
            dataSet.Tables["Person"].Rows.Add(new object[] { 3, "Park", 20 });
            dataSet.Tables["Person"].Rows.Add(new object[] { 4, "Lee", 22 });
            dataGridView1.DataSource = dataSet.Tables["Peoson"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Person"].Rows.Add(new object[] {
                dataSet.Tables["Person"].Rows.Count +1,
                tbNAme.Text,
                int.Parse(tbAge.Text) });
        }
    }
}
