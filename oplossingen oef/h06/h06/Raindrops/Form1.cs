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

namespace Raindrops
{
    public partial class Form1 : Form
    {
        private Random randomNumber = new Random();
        private Graphics paper;
        private int x, y, size;
        private SolidBrush brush;

        public Form1()
        {
            InitializeComponent();

            paper = pictureBox1.CreateGraphics();
            gapLabel.Text = Convert.ToString(trackBar1.Value);
            brush = new SolidBrush(Color.Black);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.White);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            x = randomNumber.Next(0, pictureBox1.Width);
            y = randomNumber.Next(0, pictureBox1.Height);
            size = randomNumber.Next(1, 20);
            paper.FillEllipse(brush, x, y, size, size);

            // set new interval for timer
            timer1.Stop();
            timer1.Interval = randomNumber.Next(1, trackBar1.Value);
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int timeGap = trackBar1.Value;
            gapLabel.Text = Convert.ToString(timeGap);
        }
    }
}
