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

namespace Oef14_16_Ballonnen
{
    public partial class Form1 : Form
    {
        private Balloon[] party = new Balloon[10];

        public Form1()
        {
            InitializeComponent();

            party[0] = new Balloon(10, 10, 50);
            party[1] = new Balloon(50, 50, 100);
            party[2] = new Balloon(100, 100, 200);
        }

        private void tekenButton_Click(System.Object sender, System.EventArgs e)
        {
            DisplayBalloons();
        }

        private void DisplayBalloons()
        {
            int b = 0;
            Graphics drawArea = balloonsPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            drawArea.Clear(Color.White);
            for (b = 0; b <= 2; b++)
            {
                party[b].Display(drawArea, myPen);
            }
        }

        private void vergrootButton_Click(System.Object sender, System.EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < party.Length; i++)
            {
                if ((party[i] != null))
                {
                    party[i].ChangeSize(r.Next(10, 30));
                }
            }
            DisplayBalloons();
        }


        private void verschuifButton_Click(System.Object sender, System.EventArgs e)
        {
            for (int i = 0; i < party.Length; i++)
            {
                if ((party[i] != null))
                {
                    party[i].MoveHorizontal(Convert.ToInt32(afstandTextBox.Text));
                }
            }
            DisplayBalloons();
        }
    }
}
