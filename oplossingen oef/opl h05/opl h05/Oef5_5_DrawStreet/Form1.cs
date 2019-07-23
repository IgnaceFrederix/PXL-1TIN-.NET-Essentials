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

namespace Oef5_5_DrawStreet
{
    /// <summary>
    /// Hoofdstuk 5, oefening 5: DrawStreet
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics paper;
            Pen myPen = new Pen(Color.Black);
            paper = pictureBox1.CreateGraphics();
            DrawStreet(paper, myPen, 10, 90, 50, 50);
        }

        private void DrawStreet(Graphics drawingArea,
                                Pen penToUse,
                                int xPos,
                                int yPos,
                                int width,
                                int height)
        {
            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            xPos = xPos + width + 20;

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            xPos = xPos + width + 20;

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            xPos = xPos + width + 20;

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
        }

        private void DrawHouse(Graphics drawingArea, 
                           Pen penToUse, 
                           int TopRoofX, 
                           int TopRoofY, 
                           int width , 
                           int height)
        {
            DrawTriangle(drawingArea, penToUse, TopRoofX, TopRoofY, width, height);
            drawingArea.DrawRectangle(penToUse, TopRoofX, TopRoofY + height, width, height);
        }

        private void DrawTriangle(Graphics drawingArea, 
                              Pen penToUse, 
                              int xPos, 
                              int yPos, 
                              int width, 
                              int height)
        {    
            // lijn van boven naar beneden
            drawingArea.DrawLine(penToUse, xPos, yPos, xPos, yPos + height);
            // lijn van beneden naar rechts
            drawingArea.DrawLine(penToUse, xPos, yPos + height, xPos + width, yPos + height);
            //lijn van boven naar rechts
            drawingArea.DrawLine(penToUse, xPos, yPos, xPos + width, yPos + height);
        }
    }
}
