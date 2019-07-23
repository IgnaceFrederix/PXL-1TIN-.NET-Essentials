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

namespace Oef10_1_Ballonnen
{
    public partial class Form1 : Form
    {
        private Balloon myBalloon;
        Graphics drawArea;
        int step;
        
        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            myBalloon = new Balloon("ballonnetje", "zwart");
            drawArea = balloonPictureBox.CreateGraphics();
            step = 20;
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            myBalloon.MoveRight(step);
            DrawCircle();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            myBalloon.MoveUp(step);
            DrawCircle();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            myBalloon.MoveLeft(step);
            DrawCircle();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            myBalloon.MoveDown(step);
            DrawCircle();
        }

        private void DrawCircle()
        {
            drawArea.Clear(Color.White);
            myBalloon.Display(drawArea);
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            myBalloon.ChangeSize(step);
            DrawCircle();
        }

        private void toonNaamEnKleurButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myBalloon.GeefKleurEnNaam());
        }
    }
}
