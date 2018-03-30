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

namespace WindowsForms180330_3
{
    public partial class Form1 : Form
    {
        StreamReader fileReader;
        StreamWriter fileWriter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fileReader = new StreamReader("phone.txt");
            }
            catch
            {
                MessageBox.Show("File Open Failed");
            }
        }

        private void bntNext_Click(object sender, EventArgs e)
        {
            if(fileReader == null)
            {
                MessageBox.Show("File Reader is null");
                return;
            }

            if (fileReader.Peek() < 0)
                fileReader.BaseStream.Seek(0, SeekOrigin.Begin);

            this.txtCompany.Text = fileReader.ReadLine();
            this.txtPNumber.Text = fileReader.ReadLine();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text.CompareTo("") == 0)
            {
                MessageBox.Show("상호명을 입력하세요");
                return;
            }
            if (txtPNumber.Text.CompareTo("") == 0)
            {
                MessageBox.Show("전화번호를 입력하세요");
                return;
            }
            if (fileReader != null)
            {
                fileReader.Close();
                fileReader.Dispose();
                fileReader = null;
            }
            if (this.fileWriter == null)
                this.fileWriter = new StreamWriter("phone.txt", true);

            fileWriter.WriteLine(this.txtCompany.Text);
            fileWriter.WriteLine(this.txtPNumber.Text);
            fileWriter.Flush();
            fileWriter.Close();
            fileWriter.Dispose();
            fileWriter = null;

            txtCompany.Clear();
            txtPNumber.Clear();
            txtCompany.Focus();

            if (fileReader == null)
                fileReader = new StreamReader("phone.txt");

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            if (this.fileReader != null)
                this.fileReader.Close();

            if (this.fileWriter != null)
                this.fileWriter.Close();

            this.Close();
        }
    }
}
