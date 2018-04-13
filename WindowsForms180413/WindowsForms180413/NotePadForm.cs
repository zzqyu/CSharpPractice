using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WindowsForms180413
{
    public partial class NotePadForm : Form
    {
        public NotePadForm()
        {
            InitializeComponent();
            LoadSetting();
        }

        private MenuStrip menuStrip1;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.오려내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙혀넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.글자색바꾸기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바탕색바꾸기BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.복사하기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기vToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripMenuItem2,
            this.끝내기XToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // 새파일NToolStripMenuItem
            // 
            this.새파일NToolStripMenuItem.Name = "새파일NToolStripMenuItem";
            this.새파일NToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.새파일NToolStripMenuItem.Text = "새 파일(&N)";
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.SaveAsAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripMenuItem1,
            this.오려내기TToolStripMenuItem,
            this.복사하기CToolStripMenuItem,
            this.붙혀넣기PToolStripMenuItem,
            this.지우기DToolStripMenuItem,
            this.toolStripMenuItem3,
            this.모두선택AToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(&E)";
            this.편집ToolStripMenuItem.Click += new System.EventHandler(this.편집ToolStripMenuItem_Click);
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(&U)";
            this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.Undo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // 오려내기TToolStripMenuItem
            // 
            this.오려내기TToolStripMenuItem.Name = "오려내기TToolStripMenuItem";
            this.오려내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.오려내기TToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.오려내기TToolStripMenuItem.Text = "오려내기(&T)";
            this.오려내기TToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // 붙혀넣기PToolStripMenuItem
            // 
            this.붙혀넣기PToolStripMenuItem.Name = "붙혀넣기PToolStripMenuItem";
            this.붙혀넣기PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙혀넣기PToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.붙혀넣기PToolStripMenuItem.Text = "붙혀넣기(&P)";
            this.붙혀넣기PToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // 지우기DToolStripMenuItem
            // 
            this.지우기DToolStripMenuItem.Name = "지우기DToolStripMenuItem";
            this.지우기DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.지우기DToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.지우기DToolStripMenuItem.Text = "지우기(&D)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(&A)";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // 보기vToolStripMenuItem
            // 
            this.보기vToolStripMenuItem.CheckOnClick = true;
            this.보기vToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrap,
            this.글꼴FToolStripMenuItem,
            this.toolStripMenuItem4,
            this.글자색바꾸기CToolStripMenuItem,
            this.바탕색바꾸기BToolStripMenuItem});
            this.보기vToolStripMenuItem.Name = "보기vToolStripMenuItem";
            this.보기vToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기vToolStripMenuItem.Text = "보기(&V)";
            this.보기vToolStripMenuItem.Click += new System.EventHandler(this.보기vToolStripMenuItem_Click);
            // 
            // wordWrap
            // 
            this.wordWrap.Name = "wordWrap";
            this.wordWrap.Size = new System.Drawing.Size(166, 22);
            this.wordWrap.Text = "자동 줄 바꿈(&W)";
            // 
            // 글꼴FToolStripMenuItem
            // 
            this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.글꼴FToolStripMenuItem.Text = "글꼴(&F)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(163, 6);
            // 
            // 글자색바꾸기CToolStripMenuItem
            // 
            this.글자색바꾸기CToolStripMenuItem.Name = "글자색바꾸기CToolStripMenuItem";
            this.글자색바꾸기CToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.글자색바꾸기CToolStripMenuItem.Text = "글자색 바꾸기(&C)";
            // 
            // 바탕색바꾸기BToolStripMenuItem
            // 
            this.바탕색바꾸기BToolStripMenuItem.Name = "바탕색바꾸기BToolStripMenuItem";
            this.바탕색바꾸기BToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.바탕색바꾸기BToolStripMenuItem.Text = "바탕색 바꾸기(&B)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 340);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // 복사하기CToolStripMenuItem
            // 
            this.복사하기CToolStripMenuItem.Name = "복사하기CToolStripMenuItem";
            this.복사하기CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사하기CToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.복사하기CToolStripMenuItem.Text = "복사하기(&C)";
            this.복사하기CToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // NotePadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePadForm";
            this.Text = "NotePadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotePadForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 편집ToolStripMenuItem;

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem 보기vToolStripMenuItem;

        private void 보기vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem 새파일NToolStripMenuItem;
        private ToolStripMenuItem 열기OToolStripMenuItem;
        private ToolStripMenuItem 저장SToolStripMenuItem;
        private ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private ToolStripMenuItem 도움말HToolStripMenuItem;

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 끝내기XToolStripMenuItem;

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem 실행취소UToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 오려내기TToolStripMenuItem;
        private ToolStripMenuItem 붙혀넣기PToolStripMenuItem;
        private ToolStripMenuItem 지우기DToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem 모두선택AToolStripMenuItem;
        private ToolStripMenuItem wordWrap;
        private ToolStripMenuItem 글꼴FToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem 글자색바꾸기CToolStripMenuItem;
        private ToolStripMenuItem 바탕색바꾸기BToolStripMenuItem;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream strm = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(strm);

                textBox1.Text = reader.ReadToEnd();

                reader.Close();
                strm.Close();

                this.Text = openFileDialog1.FileName;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = this.Text;
            StreamWriter writer = new StreamWriter(fname);

            writer.Write(textBox1.Text);

            writer.Close();
        }

        private void SaveAsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fname = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(fname);

                writer.Write(textBox1.Text);

                writer.Close();

                this.Text = fname;
            }
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
        private void Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void SelectAll_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void WordWrap_Click(object sender, EventArgs e)
        {
            if (textBox1.WordWrap)
            {
                textBox1.WordWrap = false;
                wordWrap.Checked = true;
            }
        }
        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
        private void fontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = fontDialog1.Color;
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

                textBox1.Font = new System.Drawing.Font(fname, fsize);

                int color;
                color = Convert.ToInt32(subkey.GetValue("ForeColor"));
                textBox1.ForeColor = System.Drawing.Color.FromArgb(color);

                color = Convert.ToInt32(subkey.GetValue("BackColor"));
                textBox1.BackColor = System.Drawing.Color.FromArgb(color);
            }
            catch { }
        }
        private void SaveSetting() {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey("Software", true);
                RegistryKey newkey = rk.CreateSubKey("NotePad");

                newkey.SetValue("FontName", textBox1.Font.FontFamily.GetName(0));
                newkey.SetValue("FontSize", Convert.ToString(textBox1.Font.Size));

                newkey.SetValue("ForeColor", Convert.ToString(textBox1.ForeColor.ToArgb()));
                newkey.SetValue("BackColor", Convert.ToString(textBox1.BackColor.ToArgb()));
            }
            catch { }
        }
    }
}
