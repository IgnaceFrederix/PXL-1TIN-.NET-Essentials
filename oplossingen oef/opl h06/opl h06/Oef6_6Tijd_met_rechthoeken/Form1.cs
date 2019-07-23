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

namespace Oef6_6_Tijd_met_rechthoeken
{
    /// <summary>
    /// Hoofdstuk 6, oefening 6: Tijd met rechthoeken
    /// </summary>
    public partial class Form1 : Form
    { 
        private int seconden;
        private int getekendeminuten;
        private int getekendeseconden;
        private Graphics paper;
        private SolidBrush myBrush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            paper = pictureBox1.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            paper.Clear(Form.DefaultBackColor);

            seconden += 1;

            getekendeseconden = seconden % 60;
            getekendeminuten = seconden / 60;
            // getekendeminuten = seconden % 3600 / 60 dan blijft je programma nog werken na een uur
            paper.FillRectangle(myBrush, 0, 20, getekendeseconden * 10, 30);
            paper.FillRectangle(myBrush, 0, 70, getekendeminuten * 10, 30);
        }
    }
}
