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
    public partial class Form1 : Form
    {
        private Balloon balloon;
        private Graphics drawArea;
        
        public Form1()
        {
            InitializeComponent();

            balloon = new Balloon();
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
    }
}
