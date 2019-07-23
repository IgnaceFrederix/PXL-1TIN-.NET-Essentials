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

namespace Oef20_1_Balloon
{
    public partial class Form1 : Form
    {
        private Balloon theBalloon;
        
        public Form1()
        {
            InitializeComponent();
            theBalloon = new Balloon();
        }

        private void upButton_Click(System.Object sender, System.EventArgs e)
        {
            theBalloon.MoveUp();
            Draw();
        }

        private void downButton_Click(System.Object sender, System.EventArgs e)
        {
            theBalloon.MoveDown();
            Draw();
        }

        private void radiusTrackBar_Scroll(System.Object sender, System.EventArgs e)
        {
            theBalloon.Radius = radiusTrackBar.Value;
            Draw();
        }

        private void Draw()
        {
            RadiusLabel.Text = Convert.ToString(theBalloon.Radius);
            theBalloon.Display(balloonPictureBox);
        }
    }
}
