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

namespace Oef6_7_Meetkundespelletje
{
    public partial class Form1 : Form
    {
        private Graphics papier;
        private Pen pen;
        private int start = 0;
        private int X1;
        private int X2;
        private int X3;
        private int Y1;
        private int Y2;
        private int Y3;
        private int tijd = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void horizTrackBar_Scroll(object sender, EventArgs e)
        {
            papier = spelPictureBox.CreateGraphics();
            pen = new Pen(Color.Black);
            int X = horizTrackBar.Value;
            int Y = vertTrackBar.Value;
            Teken(papier, pen, X, Y);
            spelTimer.Start();
            papier.DrawEllipse(pen, X1, Y1, 2, 2);
            papier.DrawEllipse(pen, X2, Y2, 2, 2);
            papier.DrawEllipse(pen, X3, Y3, 2, 2);
        }

        private void vertTrackBar_Scroll(object sender, EventArgs e)
        {
            papier = spelPictureBox.CreateGraphics();
            pen = new Pen(Color.Black);
            int X = horizTrackBar.Value;
            int Y = vertTrackBar.Value;
            Teken(papier, pen, X, Y);
            spelTimer.Start();
            papier.DrawEllipse(pen, X1, Y1, 2, 2);
            papier.DrawEllipse(pen, X2, Y2, 2, 2);
            papier.DrawEllipse(pen, X3, Y3, 2, 2);
        }

        private void Teken(Graphics papier, Pen penneke, int X, int Y)
        {
            papier.Clear(Color.LightGray);
            papier.DrawEllipse(penneke, X, 200 - Y, diamTrackBar.Value, diamTrackBar.Value);
        }

        private void diamTrackBar_Scroll(object sender, EventArgs e)
        {
            papier = spelPictureBox.CreateGraphics();
            pen = new Pen(Color.Black);
            int X = horizTrackBar.Value;
            int Y = vertTrackBar.Value;
            spelTimer.Start();
            Teken(papier, pen, X, Y);
            papier.DrawEllipse(pen, X1, Y1, 2, 2);
            papier.DrawEllipse(pen, X2, Y2, 2, 2);
            papier.DrawEllipse(pen, X3, Y3, 2, 2);
        }

        private void spelTimer_Tick(object sender, EventArgs e)
        {
            tijd = tijd + 1;
            lblTijd.Text = Convert.ToString(tijd);
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (start == 0)
            {
                start = 1;
                spelTimer.Start();
                actionButton.Text = "Stop";
                papier = spelPictureBox.CreateGraphics();
                pen = new Pen(Color.Black);
                Teken_Cirkelpunten();
                papier.DrawEllipse(pen, X1, Y1, 2, 2);
                papier.DrawEllipse(pen, X2, Y2, 2, 2);
                papier.DrawEllipse(pen, X3, Y3, 2, 2);
            }
            else
            {
                start = 0;
                spelTimer.Stop();
                tijd = 0;
                actionButton.Text = "Start";
            }
        }

        private void Teken_Cirkelpunten()
        {
            papier = spelPictureBox.CreateGraphics();
            pen = new Pen(Color.Black);
            Random rand = new Random();
            X1 = rand.Next(1, 200);
            Y1 = rand.Next(1, 200);
            X2 = rand.Next(1, 200);
            Y2 = rand.Next(1, 200);
            X3 = rand.Next(1, 200);
            Y3 = rand.Next(1, 200);
            papier.DrawEllipse(pen, X1, Y1, 2, 2);
            papier.DrawEllipse(pen, X2, Y2, 2, 2);
            papier.DrawEllipse(pen, X3, Y3, 2, 2);
        }
    }
}
