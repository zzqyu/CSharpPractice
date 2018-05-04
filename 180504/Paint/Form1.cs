﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTool
{
    public partial class Form1 : Form
    {
        private bool line;
        private bool rect;
        private bool circle;
        private Point start;
        private Point finish;
        private Pen pen;
        private int nline;
        private int nrect;
        private int ncircle;
        private int i;
        private int thick;
        private bool isSolid;
        private MyLines[] mylines;
        private MyRect[] myrect;
        private MyCircle[] mycircle;



        public Form1()
        {
            InitializeComponent();
            SetupVar();
        }
        private void SetupVar() {
            i = 0;
            thick = 1;
            isSolid = true;
            line = false;
            rect = false;
            circle = false;
            start = new Point(0, 0);
            finish = new Point(0, 0);
            pen = new Pen(Color.Black);
            mylines = new MyLines[100];
            myrect = new MyRect[100];
            mycircle = new MyCircle[100];
            nline = 0;
            nrect = 0;
            ncircle = 0;
            line0Button.Pushed = false;
            line1Button.Pushed = true;
            line2Button.Pushed = false;
            line3Button.Pushed = false;

            SetupMine();


        }
        private void SetupMine()
        {
            for(i=0; i < 100; i++)
            {
                mylines[i] = new MyLines();
                myrect[i] = new MyRect();
                mycircle[i] = new MyCircle();
            }
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if(e.Button == newButton)
            {
                lineButton.Pushed = false;
                rectButton.Pushed = false;
                circleButton.Pushed = false;

                SetupVar();
                panel1.Refresh();
            }
            else if (e.Button == lineButton)
            {
                line = true;
                rect = false;
                circle = false;
                lineButton.Pushed = true;
                rectButton.Pushed = false;
                circleButton.Pushed = false;
            }
            else if (e.Button == rectButton)
            {
                line = false;
                rect = true;
                circle = false;
                lineButton.Pushed = false;
                rectButton.Pushed = true;
                circleButton.Pushed = false;
            }
            else if (e.Button == circleButton)
            {
                line = false;
                rect = false;
                circle = true;
                lineButton.Pushed = false;
                rectButton.Pushed = false;
                circleButton.Pushed = true;
            }
            else if (e.Button == line0Button)
            {
                isSolid = false;
                thick = 1;
                line0Button.Pushed = true;
                line1Button.Pushed = false;
                line2Button.Pushed = false;
                line3Button.Pushed = false;
            }
            else if (e.Button == line1Button)
            {
                isSolid = true;
                thick = 1;
                line0Button.Pushed = false;
                line1Button.Pushed = true;
                line2Button.Pushed = false;
                line3Button.Pushed = false;
            }
            else if (e.Button == line2Button)
            {
                isSolid = true;
                thick = 3;
                line0Button.Pushed = false;
                line1Button.Pushed = false;
                line2Button.Pushed = true;
                line3Button.Pushed = false;
            }
            else if (e.Button == line3Button)
            {
                isSolid = true;
                thick = 5;
                line0Button.Pushed = false;
                line1Button.Pushed = false;
                line2Button.Pushed = false;
                line3Button.Pushed = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (i = 0; i < nline; i++)
            {
                if (!mylines[i].getSolid())
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else
                {
                    pen.Width = mylines[i].getThick();
                    pen.DashStyle = DashStyle.Solid;
                }
                e.Graphics.DrawLine(pen, mylines[i].getPoint1(), mylines[i].getPoint2());
            }
            for (i = 0; i < nrect; i++)
            {
                if (!myrect[i].getSolid())
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else
                {
                    pen.Width = myrect[i].getThick();
                    pen.DashStyle = DashStyle.Solid;
                }
                e.Graphics.DrawRectangle(pen, myrect[i].getRect());
            }
            for (i = 0; i < ncircle; i++)
            {
                if (!mycircle[i].getSolid())
                {
                    pen.Width = 1;
                    pen.DashStyle = DashStyle.Dot;
                }
                else
                {
                    pen.Width = mycircle[i].getThick();
                    pen.DashStyle = DashStyle.Solid;
                }
                e.Graphics.DrawEllipse(pen, mycircle[i].getRectC());
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((start.X == 0) && (start.Y == 0)) return;
            finish.X = e.X;
            finish.Y = e.Y;

            if (line = true)
                mylines[nline].setPoint(start, finish, thick, isSolid);
            if (rect = true)
                myrect[nrect].setRect(start, finish, thick, isSolid);
            if (circle = true)
                mycircle[ncircle].setRectC(start, finish, thick, isSolid);

            panel1.Invalidate(true);
            panel1.Update();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (line == true) nline++;
            if (rect == true) nrect++;
            if (circle == true) ncircle++;

            start.X = 0;
            start.Y = 0;
            finish.X = 0;
            finish.Y = 0;
        }
    }
}