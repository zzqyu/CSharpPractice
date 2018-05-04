using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180504
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            SolidBrush clearBrush = new SolidBrush(DefaultBackColor);
            Graphics g = CreateGraphics();

            책.Clear();
            잡지.Clear();
            음식.Clear();
            책.Focus();

            g.FillEllipse(clearBrush, 140, 150, 100, 100);
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntDisplay_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            decimal totalSales;
            decimal bookSales;
            decimal periodicalSales;
            decimal foodSales;


            try {
                bookSales = Decimal.Parse(책.Text);

                try {
                    periodicalSales = Decimal.Parse(잡지.Text);
                    try {
                        foodSales = Decimal.Parse(음식.Text);
                        totalSales = bookSales + periodicalSales + foodSales;

                        SolidBrush bookBr = new SolidBrush(Color.Blue);
                        SolidBrush periodicalBr = new SolidBrush(Color.Yellow);
                        SolidBrush foodBr = new SolidBrush(Color.Red);

                        if (totalSales != 0) {
                            int endBook = (int)(bookSales / totalSales * 360);
                            int endPeriodical = (int)(periodicalSales / totalSales * 360);
                            int endFood = (int)(foodSales / totalSales * 360);
                            g.FillPie(bookBr, 140, 150, 100, 100, 0, endBook);
                            g.FillPie(periodicalBr, 140, 150, 100, 100, endBook, endPeriodical);
                            g.FillPie(foodBr, 140, 150, 100, 100, endBook+ endPeriodical, endFood);
                        }
                    }
                    catch {
                        MessageBox.Show("Invalid Food Salse");
                    }
                }
                catch {
                    MessageBox.Show("Invalid Food Salse");

                }

            } catch {
                MessageBox.Show("Invalid Food Salse");

            }
        }
    }
}
