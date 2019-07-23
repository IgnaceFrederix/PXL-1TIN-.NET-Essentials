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

namespace Oval_Shape
{
    public partial class Form1 : Form
    {
        private Graphics paper;
        private SolidBrush brush;

        public Form1()
        {
            InitializeComponent();

            paper = pictureBox1.CreateGraphics();
            vertTrackBar.Minimum = 0;
            vertTrackBar.Maximum = pictureBox1.Height;
            vertLabel.Text = Convert.ToString(vertTrackBar.Value);

            horizTrackBar.Minimum = 0;
            horizTrackBar.Maximum = pictureBox1.Width;
            horizLabel.Text = Convert.ToString(horizTrackBar.Value);

            brush = new SolidBrush(Color.Black);
        }

        private void horizTrackBar_Scroll(object sender, EventArgs e)
        {
            horizLabel.Text = Convert.ToString(horizTrackBar.Value);
            UpdateEllipse();
        }

        private void vertTrackBar_Scroll(object sender, EventArgs e)
        {
            vertLabel.Text = Convert.ToString(vertTrackBar.Value);
            UpdateEllipse();
        }

        private void UpdateEllipse()
        {
            paper.Clear(Color.White);
            paper.FillEllipse(brush, 0, 0,
                              horizTrackBar.Value,
                              vertTrackBar.Value);
        }

    }
}
