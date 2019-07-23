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

namespace Testvraag8_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawSheet()
        {
            int y = 10;
            Graphics paper = sheetPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            paper.Clear(Color.White);

            for (int staves = 0; staves < 8; staves++)
            {
                for (int lines = 0; lines < 5; lines++)
                {
                    paper.DrawLine(pen, 10, y, 90, y);
                    y = y + 2;
                }
                y = y + 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSheet();
        }
    }
}
