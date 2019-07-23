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

namespace Oef3_3_Huis
{

    // De coördinaten van dit huisje zijn verkregen als volgt:
    // <list>
    // <item>Teken met <a href="http://sketchup.google.com/">Google Sketchup</a> een huisje en exporteer naar jpg.</item>
    // <item>Open dit met <a href="http://www.getpaint.net">Paint.Net</a> en lees de coördinaten uit.</item>
    // </list>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics paper = drawAreaPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Blue);

            // Dak
            paper.DrawLine(pen, 185, 70, 475, 127);
            paper.DrawLine(pen, 185, 70, 92, 216);
            paper.DrawLine(pen, 185, 70, 475, 127);
            paper.DrawLine(pen, 475, 127, 380, 307);
            paper.DrawLine(pen, 92, 216, 380, 307);
            paper.DrawLine(pen, 475, 127, 547, 216);

            // Muren
            paper.DrawLine(pen, 92, 216, 108, 391);
            paper.DrawLine(pen, 380, 307, 380, 508);
            paper.DrawLine(pen, 108, 391, 380, 508);
            paper.DrawLine(pen, 547, 216, 536, 390);
            paper.DrawLine(pen, 380, 508, 536, 390);

            // Raam links
            paper.DrawLine(pen, 136, 272, 187, 289);
            paper.DrawLine(pen, 187, 289, 191, 353);
            paper.DrawLine(pen, 191, 353, 142, 335);
            paper.DrawLine(pen, 142, 335, 136, 272);

            // Deur
            paper.DrawLine(pen, 269, 461, 264, 357);
            paper.DrawLine(pen, 264, 357, 316, 377);
            paper.DrawLine(pen, 316, 377, 318, 482);

            // Raam rechts
            paper.DrawLine(pen, 409, 326, 456, 301);
            paper.DrawLine(pen, 456, 301, 454, 371);
            paper.DrawLine(pen, 454, 371, 408, 400);
            paper.DrawLine(pen, 408, 400, 409, 326);
        }
    }
}
