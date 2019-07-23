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

namespace Balloon
{
    public partial class GUIForm : Form
    {
        private Balloon balloon;
        private Graphics graphics;
        
        public GUIForm()
        {
            InitializeComponent();

            balloon = new Balloon();
            graphics = balloonPictureBox.CreateGraphics();
            radiusLabel.Text = Convert.ToString(balloon.Radius);
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {
            balloon.Radius = radiusTrackBar.Value;
            radiusLabel.Text = Convert.ToString(balloon.Radius);
            balloon.Display(graphics);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            balloon.MoveUp(5);
            balloon.Display(graphics);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            balloon.MoveDown(5);
            balloon.Display(graphics);
        }
    }
}
