//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Balloon
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Pen pen = new Pen(Color.Black);

        public Balloon()
        {
            x = 50;
            y = 50;
            diameter = 20;
        }

        public Balloon(int initialX)
        {
            x = initialX;
            y = 50;
            diameter = 20;
        }

        public Balloon(int initialX, int initialY)
        {

            x = initialX;
            y = initialY;
            diameter = 20;
        }
        
        public Balloon(int initialX,
                       int initialY,
                       int initialDiameter)
        {
            x = initialX;
            y = initialY;
            diameter = initialDiameter;
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
        }

        public void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }

        public double Area
        {
            get
            {
                return this.CalcArea();
            }
        }

        private double CalcArea()
        {
            double radius;
            radius = diameter / 2.0;
            return Math.PI * radius * radius;
        }
    }
}
