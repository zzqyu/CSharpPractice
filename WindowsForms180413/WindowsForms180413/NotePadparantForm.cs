using System;

using System.ComponentModel;

using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WindowsForms180413
{
    public partial class NotePadParantForm : Form
    {
        NotePadChildForm child;
        int nChild = 0;
        public NotePadParantForm()
        {
            InitializeComponent();
            LoadSetting();
        }

        

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void 보기vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = new NotePadChildForm();
            child.MdiParent = this;
            child.Text = "NONAME" + nChild++;
            child.Show();
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream strm = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(strm);

                child = new NotePadChildForm();
                child.MdiParent = this;
                child.Text = "NONAME" + nChild++;
                child.Show();

                child.getTextBox().Text = reader.ReadToEnd();
                reader.Close();
                strm.Close();

                this.Text = openFileDialog1.FileName;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                child = (NotePadChildForm)(this.ActiveMdiChild);
                string fname = this.Text;
                StreamWriter writer = new StreamWriter(fname);

                writer.Write(child.getTextBox().Text);

                writer.Close();
            }
            
        }

        private void SaveAsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                child = (NotePadChildForm)(this.ActiveMdiChild);
                string fname = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(fname);

                writer.Write(child.getTextBox().Text);

                writer.Close();

                this.Text = fname;
            }
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            child = (NotePadChildForm)(this.ActiveMdiChild);
            child.getTextBox().Undo();
        }
        private void Cut_Click(object sender, EventArgs e)
        {
            child = (NotePadChildForm)(this.ActiveMdiChild);
            child.getTextBox().Cut();
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            child = (NotePadChildForm)(this.ActiveMdiChild);
            child.getTextBox().Copy();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            child = (NotePadChildForm)(this.ActiveMdiChild);
            child.getTextBox().Paste();
        }
        private void SelectAll_Click(object sender, EventArgs e)
        {
            child = (NotePadChildForm)(this.ActiveMdiChild);
            child.getTextBox().SelectAll();
        }

        private void WordWrap_Click(object sender, EventArgs e)
        {
            if (child.getTextBox().WordWrap)
            {
                child.getTextBox().WordWrap = false;
                wordWrap.Checked = false;
            }
            else
            {
                child.getTextBox().WordWrap = false;
                wordWrap.Checked = false;
            }
        }
        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                child.getTextBox().Font = fontDialog1.Font;
            }
        }
        private void fontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                child.getTextBox().ForeColor = fontDialog1.Color;
            }
        }
        private void backColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                child.getTextBox().BackColor = fontDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotePadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }
        private void LoadSetting() {
            try
            {
                RegistryKey subkey = Registry.LocalMachine.OpenSubKey("SoftWare\\NotePad");

                string fname = subkey.GetValue("FontName").ToString();
                Single fsize = Convert.ToSingle(subkey.GetValue("FontSize"));

                child.getTextBox().Font = new System.Drawing.Font(fname, fsize);

                int color;
                color = Convert.ToInt32(subkey.GetValue("ForeColor"));
                child.getTextBox().ForeColor = System.Drawing.Color.FromArgb(color);

                color = Convert.ToInt32(subkey.GetValue("BackColor"));
                child.getTextBox().BackColor = System.Drawing.Color.FromArgb(color);
            }
            catch { }
        }
        private void SaveSetting() {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey("Software", true);
                RegistryKey newkey = rk.CreateSubKey("NotePad");

                newkey.SetValue("FontName", child.getTextBox().Font.FontFamily.GetName(0));
                newkey.SetValue("FontSize", Convert.ToString(child.getTextBox().Font.Size));

                newkey.SetValue("ForeColor", Convert.ToString(child.getTextBox().ForeColor.ToArgb()));
                newkey.SetValue("BackColor", Convert.ToString(child.getTextBox().BackColor.ToArgb()));
            }
            catch { }
        }
    }
}
