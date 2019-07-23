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

namespace Oef5_6_DrawStreetInperspective
{
    /// <summary>
    /// Hoofdstuk 5, oefening 5: DrawStreetInPerspective
    /// Bemerk ook het nuttig gebruik van ref bij de method VerkleinEnVerplaats
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
            DrawStreetInPerspective(paper, myPen, 10, 90, 50, 50);
        }

        private void DrawStreetInPerspective(Graphics drawingArea,
                                Pen penToUse,
                                int xPos,
                                int yPos,
                                int width,
                                int height)
        {
            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            VerkleinEnVerplaats(ref xPos, ref width, ref height);

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            VerkleinEnVerplaats(ref xPos, ref width, ref height);

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
            VerkleinEnVerplaats(ref xPos, ref width, ref height);

            DrawHouse(drawingArea, penToUse, xPos, yPos, width, height);
        }
        
        private void VerkleinEnVerplaats(ref int xPos, 
                                    ref int width, 
                                    ref int height)
        {
            xPos = xPos + width + 20;
            width = Convert.ToInt32(width * 0.8);
            height = Convert.ToInt32(height * 0.8);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
