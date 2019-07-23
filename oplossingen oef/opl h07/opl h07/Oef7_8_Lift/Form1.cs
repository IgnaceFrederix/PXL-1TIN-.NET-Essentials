//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oef7_8_Lift
{
    public partial class Form1 : Form
    {
        enum Richting
        {
            Omhoog = 1,
            Omlaag = -1,
            Stilstand = 0,
        }

        private SolidBrush pen;
        private int y;
        private int dy = 4;
        private int hoogteLift = 60;
        private Richting richt = Richting.Stilstand;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            pen = new SolidBrush(Color.Red);
            omhoogButton.Enabled = true;
            omlaagButton.Enabled = true;
            y = 250;
        }

        private void liftPictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics papier = e.Graphics;
            papier.Clear(Color.LightGray);
            papier.FillRectangle(pen, 40, y, 40, hoogteLift);
        }

        private void liftTimer_Tick(object sender, System.EventArgs e)
        {
            if ((richt == Richting.Omhoog))
            {
                y = Convert.ToInt32(((y - dy) < 0) ? 0 : (y - dy));
            }
            else if ((richt == Richting.Omlaag))
            {
                y = Convert.ToInt32(((y + dy) > (liftPictureBox.Height - hoogteLift)) ?
                                    (liftPictureBox.Height - hoogteLift) : (y + dy));
            }
            liftPictureBox.Invalidate();
            if (y == 0)
            {
                liftTimer.Stop();
                omhoogButton.Enabled = false;
                omlaagButton.Enabled = true;
            }
            if (y == (liftPictureBox.Height - hoogteLift))
            {
                liftTimer.Stop();
                omhoogButton.Enabled = true;
                omlaagButton.Enabled = false;
            }
        }

        private void omhoogButton_Click(object sender, System.EventArgs e)
        {
            if ((richt == Richting.Stilstand) || (richt == Richting.Omlaag))
            {
                richt = Richting.Omhoog;
                liftTimer.Start();
            }
        }

        private void omlaagButton_Click(object sender, System.EventArgs e)
        {
            if ((richt == Richting.Stilstand) || (richt == Richting.Omhoog))
            {
                richt = Richting.Omlaag;
                liftTimer.Start();
            }
        }
    }
}
