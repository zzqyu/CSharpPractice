using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms180413
{
    public partial class ThreadForm : Form
    {
        private Thread m_threadPlus;
        private Thread m_threadMinus;

        private int m_nValue = 0;
        private int m_nPlusCount = 0;
        private int m_nMinusCount = 0;

        public delegate void DelegateShowText(string strLabel, string strText);
        public DelegateShowText DelegateShowTextInstance;

        public ThreadForm()
        {
            DelegateShowTextInstance = new DelegateShowText(this.ShowText);
            InitializeComponent();
        }

        private void ShowText(string strLabel, string strText)
        {
            switch (strLabel)
            {
                case "label1":
                    label1.Text = strText;
                    break;
                case "label2":
                    label2.Text = strText;
                    break;
                case "label3":
                    label3.Text = strText;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_threadPlus = new Thread(new ThreadStart(ThreadPlus));
            m_threadMinus = new Thread(new ThreadStart(ThreadMinus));

            m_threadPlus.Start();
            m_threadMinus.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_threadPlus.IsAlive)
                m_threadPlus.Abort();
            if (m_threadMinus.IsAlive)
                m_threadMinus.Abort();
        }
        private void ThreadPlus()
        {
            while (m_nPlusCount < 1000)
            {
                int nValue = m_nValue + 1;
                Thread.Sleep(1);
                m_nValue = nValue;
                Invoke(DelegateShowTextInstance, new object[] { "label1", Convert.ToString(m_nValue) });
                m_nPlusCount++;
                Invoke(DelegateShowTextInstance, new object[] { "label2", Convert.ToString(m_nPlusCount) });
                

            }
        }
        private void ThreadMinus()
        {
            while (m_nMinusCount < 1000)
            {
                int nValue = m_nValue - 1;
                Thread.Sleep(1);
                m_nValue = nValue;
                Invoke(DelegateShowTextInstance, new object[] { "label1", Convert.ToString(m_nValue) });
                m_nMinusCount--;
                Invoke(DelegateShowTextInstance, new object[] { "label3", Convert.ToString(m_nMinusCount) });

            }
        }
    }
}
