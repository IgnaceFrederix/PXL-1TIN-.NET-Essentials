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

namespace BalloonWithProperties
{
    public partial class Form1 : Form
    {
        private BalloonWithProperties balloon;
        private Graphics drawArea;
        
        public Form1()
        {
            InitializeComponent();

            balloon = new BalloonWithProperties();
            drawArea = balloonPictureBox.CreateGraphics();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            balloon.MoveRight(20);
            drawArea.Clear(Color.White);
            balloon.Display(drawArea);
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            balloon.ChangeSize(20);
            drawArea.Clear(Color.White);
            balloon.Display(drawArea);
        }

        private void changeXButton_Click(object sender, EventArgs e)
        {
            balloon.XCoord = Convert.ToInt32(xCoordTextBox.Text);
            drawArea.Clear(Color.White);
            balloon.Display(drawArea);
        }

        private void displayXButton_Click(object sender, EventArgs e)
        {
            xCoordTextBox.Text = Convert.ToString(balloon.XCoord);
        }
    }
}
