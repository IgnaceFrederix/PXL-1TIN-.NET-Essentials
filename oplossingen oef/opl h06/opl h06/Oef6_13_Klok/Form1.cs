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

namespace Oef6_13_Klok
{
    /// <summary>
    ///  Hoofdstuk 6, oefening 13: .NET klok
    /// </summary>
    public partial class Form1 : Form
    {
        private Graphics paper;
        private int seconden;
        private int xMiddelpunt;
        private int yMiddelpunt;
        private DateTime huidigeTijd;

        public Form1()
        {
            InitializeComponent();
            paper = klokPanel.CreateGraphics();
            xMiddelpunt = klokPanel.Width / 2;
            yMiddelpunt = klokPanel.Height / 2;
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            int uren;
            int minuten;

            paper.Clear(klokPanel.BackColor);

            huidigeTijd = DateTime.Now;
            seconden = huidigeTijd.Second;
            minuten = huidigeTijd.Minute;
            uren = huidigeTijd.Hour;

            // Teken Secondenwijzer
            DrawTime(seconden, 70);

            // Teken Minutenwijzer
            DrawTime(minuten, 60);

            // Teken Urenwijzer
            DrawTime(uren, 40, "hours");

            // Tijd digitaal weergeven
            secLabel.Text = Convert.ToString(seconden);
            minLabel.Text = Convert.ToString(minuten);
            urenLabel.Text = Convert.ToString(uren);
        }

        private void DrawBorder(Graphics paper)
        {
            Pen bic = new Pen(Color.PowderBlue, 5);
            int straal = 100;

            paper.DrawEllipse(bic, xMiddelpunt - straal, yMiddelpunt - straal, 2 * straal, 2 * straal);
        }

     // DrawTime nodig om minuten- en secondenwijzer te kunnen tekenen (1 sec/min = 6°)
        private void DrawTime(int tijd, int lengte)
        {
            Pen myPen = null;
            Pen SchaalPen = new Pen(Color.PowderBlue);
            int x2, y2;
           
            if (lengte == 70)
            {
                myPen = new Pen(Color.Red, 2);
            }
            else if (lengte == 60)
            {
                myPen = new Pen(Color.Blue, 2);
            }

            int x1 = Convert.ToInt32(xMiddelpunt + (lengte * Math.Sin((6 * tijd) * (Math.PI / 180))));
            int y1 = Convert.ToInt32(yMiddelpunt - (lengte * Math.Cos((6 * tijd) * (Math.PI / 180))));

            DrawBorder(paper);
            paper.DrawLine(myPen, xMiddelpunt, yMiddelpunt, x1, y1);

            // Teken schaalverdeling
            for (int teller = 1; teller <= 60; teller++)
            {
                lengte = 73;
                x1 = Convert.ToInt32(xMiddelpunt + (68 * Math.Sin((6 * teller) * (Math.PI / 180))));
                y1 = Convert.ToInt32(yMiddelpunt + (68 * Math.Cos((6 * teller) * (Math.PI / 180))));

                // Grotere tickmarks om de 5 seconden/minuten
                if (teller % 5 == 0)
                {
                    lengte = 79;
                }

                x2 = Convert.ToInt32(xMiddelpunt + (lengte * Math.Sin((6 * teller) * (Math.PI / 180))));
                y2 = Convert.ToInt32(yMiddelpunt + (lengte * Math.Cos((6 * teller) * (Math.PI / 180))));
                paper.DrawLine(SchaalPen, x1, y1, x2, y2);
            }
        }

        // DrawTime Overloading nodig om urenwijzer te kunnen tekenen (1u = 30°)
        private void DrawTime(int tijd, int lengte, String text)
        {
            Pen myPen;

            myPen = new Pen(Color.Black, 2);

            int x1 = Convert.ToInt32(xMiddelpunt + (lengte * Math.Sin((30 * tijd) * (Math.PI / 180))));
            int y1 = Convert.ToInt32(yMiddelpunt - (lengte * Math.Cos((30 * tijd) * (Math.PI / 180))));

            paper.DrawLine(myPen, xMiddelpunt, yMiddelpunt, x1, y1);
        }
    }
}
