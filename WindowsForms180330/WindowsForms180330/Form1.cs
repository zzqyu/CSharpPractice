using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180330
{
    public enum ControlParserCase
    {
        None,
        Name,
        Age,
        Gender
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clearControls()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedItem = null;
        }

        private ControlParserCase GetControlParseCase()
        {
            if (string.Equals(txtAge.Text, string.Empty)) return ControlParserCase.Name;
            else if (string.Equals(txtAge.Text, string.Empty)) return ControlParserCase.Age;
            else if (cmbGender.SelectedItem == null) return ControlParserCase.Gender;

            return ControlParserCase.None;
        }

        private Dictionary<string, string> GetControlParseDict()
        {
            return new Dictionary<string, string>()
            {
                { "name", txtName.Text}, { "Age", txtAge.Text}, { "Gender", cmbGender.SelectedItem.ToString()}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvwPeolpleInfo.View = View.Details;

            lvwPeolpleInfo.Columns.Add("Name", "Name");
            lvwPeolpleInfo.Columns.Add("Age", "Age");
            lvwPeolpleInfo.Columns.Add("Gender", "Gender");
            lvwPeolpleInfo.Columns.Add("last", "last");

            lvwPeolpleInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvwPeolpleInfo.Columns.RemoveByKey("last");

            lvwPeolpleInfo.Columns[0].TextAlign = HorizontalAlignment.Left;
            lvwPeolpleInfo.Columns["Age"].TextAlign = HorizontalAlignment.Center;
            lvwPeolpleInfo.Columns[2].TextAlign = HorizontalAlignment.Right;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (GetControlParseCase() != ControlParserCase.None) return;

            var lvwItem = new ListViewItem(new string[lvwPeolpleInfo.Columns.Count]);

            for (int i = 0; i < lvwPeolpleInfo.Columns.Count; i++)
                lvwItem.SubItems[i].Name = lvwPeolpleInfo.Columns[i].Name;

            var controlParseDict = GetControlParseDict();

            foreach (string item in controlParseDict.Keys)
                lvwItem.SubItems[item].Text = controlParseDict[item];

            lvwPeolpleInfo.Items.Add(lvwItem);
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (lvwPeolpleInfo.FocusedItem == null) return;
            lvwPeolpleInfo.FocusedItem.Remove();
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            if (GetControlParseCase() != ControlParserCase.None) return;

            var controlParseDict = GetControlParseDict();
            foreach (string item in controlParseDict.Keys)
            {
                var lvwItem = lvwPeolpleInfo.FocusedItem;
                lvwItem.SubItems[item].Text = controlParseDict[item];
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }
    }
}
