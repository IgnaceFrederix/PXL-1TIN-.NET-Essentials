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

namespace Oef14_6_Staafdiagram
{
    public partial class Form1 : Form
    {
        private int[] rain = {7, 8, 0, 4, 3, 8, 1};

        public Form1()
        {
            InitializeComponent();
        }
        
        private void drawButton_Click(System.Object sender, System.EventArgs e)
        {
            TekenStaafDiagram(chartPictureBox, rain);
        }

        private void TekenStaafDiagram(PictureBox pbox, int[] rij)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics area = pbox.CreateGraphics();
            int u_width = pbox.Width / (rij.Length * 2 + 1);
            int u_height = Convert.ToInt32(pbox.Height / (Max(rij) * 1.2));
            // veronderstel dat de grootste waarde in de rij bijna de grootst mogelijke waarde is

            area.Clear(Color.White);
            for (int i = 0; i < rij.Length; i++)
            {
                area.FillRectangle(brush, (2 * i + 1) * u_width, pbox.Height - rij[i] * u_height, u_width, rij[i] * u_height);
            }
        }

        // Berekent het maximum van een rij
        private int Max(int[] rij)
        {
            int m = rij[0];
            for (int i = 1; i < rij.Length; i++)
            {
                if (m < rij[i])
                {
                    m = rij[i];
                }
            }
            return m;
        }
    }
}
