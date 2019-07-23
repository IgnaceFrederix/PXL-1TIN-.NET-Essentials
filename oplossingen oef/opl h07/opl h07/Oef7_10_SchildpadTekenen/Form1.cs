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

namespace Oef7_10_SchildpadTekenen
{
    public partial class Form1 : Form
    {
        private string richting;
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void naarBovenButton_Click(System.Object sender, System.EventArgs e)
        {
            richting = "Boven";
            Teken();
        }

        private void naarBenedenButton_Click(System.Object sender, System.EventArgs e)
        {
            richting = "Beneden";
            Teken();
        }

        private void naarLinksButton_Click(System.Object sender, System.EventArgs e)
        {
            if (richting == "Boven")
            {
                richting = "Links";
            }
            else if (richting == "Links")
            {
                richting = "Beneden";
            }
            else if (richting == "Beneden")
            {
                richting = "Rechts";
            }
            else if (richting == "Rechts")
            {
                richting = "Boven";
            }
            Teken();
        }

        private void naarRechtsButton_Click(System.Object sender, System.EventArgs e)
        {
            if (richting == "Boven")
            {
                richting = "Rechts";
            }
            else if (richting == "Rechts")
            {
                richting = "Beneden";
            }
            else if (richting == "Beneden")
            {
                richting = "Links";
            }
            else if (richting == "Links")
            {
                richting = "Boven";
            }
            Teken();
        }

        private void Teken()
        {
            Graphics papier = schildpadPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            papier.DrawRectangle(pen, x, y, 10, 10);
        }

        private void naarVoorButton_Click(System.Object sender, System.EventArgs e)
        {
            Graphics papier = schildpadPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            int N = Convert.ToInt32(txtNaarvoor.Text);

            if (x < 0)
            {
                x = 0;
                N = 0;
            }
            if (x > 430)
            {
                x = 430;
                N = 0;
            }
            if (y < 0)
            {
                y = 0;
                N = 0;
            }
            if (y > 360)
            {
                y = 360;
                N = 0;
            }
            if (richting == "Boven")
            {
                papier.DrawLine(pen, x, y, x, y - N);
                y = y - N;
            }
            else if (richting == "Beneden")
            {
                papier.DrawLine(pen, x, y, x, y + N);
                y = y + N;
            }
            else if (richting == "Links")
            {
                papier.DrawLine(pen, x, y, x - N, y);
                x = x - N;
            }
            else if (richting == "Rechts")
            {
                papier.DrawLine(pen, x, y, x + N, y);
                x = x + N;
            }
        }
    }
}
