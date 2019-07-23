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

namespace Balloons
{
    public partial class Form1 : Form
    {
        private Balloon[] partyList = new Balloon[10];
        
        public Form1()
        {
            InitializeComponent();

            partyList[0] = new Balloon(10, 10, 50);
            partyList[1] = new Balloon(50, 50, 100);
            partyList[2] = new Balloon(100, 100, 200);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            Graphics drawArea = balloonsPictureBox.CreateGraphics();
            drawArea.Clear(Color.White);

            //foreach (Balloon balloon in partyList)
            //{
            //    if (balloon != null)
            //    {
            //        balloon.Display(drawArea, pen);
            //    }
            //}

            for (int index = 0; index < 3; index++)
            {
                partyList[index].Display(drawArea, pen);
            }
        }
    }
}
