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

namespace Oef3_2_BoterKaasEieren
{
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

            paper.DrawLine(pen, 86, 10, 86, 186);
            paper.DrawLine(pen, 172, 10, 172, 186);
            paper.DrawLine(pen, 10, 65, 250, 65);
            paper.DrawLine(pen, 10, 130, 250, 130);
        }
    }
}
