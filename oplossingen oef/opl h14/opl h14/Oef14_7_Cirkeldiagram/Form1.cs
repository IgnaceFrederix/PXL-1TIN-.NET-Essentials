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

namespace Oef14_7_Cirkeldiagram
{
    public partial class Form1 : Form
    {
        private int[] kosten = {576, 395, 105, 40, 215, 465, 780 };
        
        private Color[] kleuren = { Color.Red,
		                            Color.Blue,
		                            Color.Green,
		                            Color.Orange,
		                            Color.Purple,
		                            Color.Brown,
		                            Color.Bisque
                                  };

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(System.Object sender, System.EventArgs e)
        {
            Graphics area = chartPictureBox.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            int totaal = Som(kosten);
            int hoek = 0;

            brush.Color = kleuren[0];

            int starthoek = Convert.ToInt32(360.0 * kosten[0] / totaal);

            area.FillPie(brush, 0, 0, chartPictureBox.Width, chartPictureBox.Height, 0, starthoek);

            for (int i = 1; i < kosten.Length; i++)
            {
                brush.Color = kleuren[i];
                hoek = Convert.ToInt32(360.0 * kosten[i] / totaal);
                area.FillPie(brush, 0, 0, chartPictureBox.Width, chartPictureBox.Height, starthoek, hoek);
                starthoek = starthoek + hoek;
            }

        }

        private int Som(int[] rij)
        {
            int s = 0;
            foreach (int t in rij)
            {
                s = s + t;
            }
            return s;
        }
    }
}
