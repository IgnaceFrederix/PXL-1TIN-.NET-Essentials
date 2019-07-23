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

namespace Tom_and_Jerry
{
    public partial class Form1 : Form
    {
        private Graphics paper;
        private SolidBrush brush;

        public Form1()
        {
            InitializeComponent();

            paper = pictureBox1.CreateGraphics();
            brush = new SolidBrush(Color.Black);
            tomTrackBar.Scroll += TrackBarCompare;
            jerryTrackBar.Scroll += TrackBarCompare;
            
        }

        private void TrackBarCompare(object sender, EventArgs e)
        {
            int tomValue = tomTrackBar.Value;
            int jerryValue = jerryTrackBar.Value;

            paper.Clear(Color.White);
            paper.FillRectangle(brush, 10, 10, tomValue, 20);
            paper.FillRectangle(brush, 10, 90, jerryValue, 20);

            if (tomValue > jerryValue)
            {
                messageLabel.Text = "Tom is bigger";
            }
            else
            {
                messageLabel.Text = "Jerry is bigger";
            }
        }

    }
}
