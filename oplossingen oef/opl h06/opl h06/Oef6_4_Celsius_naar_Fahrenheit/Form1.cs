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

namespace Oef6_4_Celsius_naar_Fahrenheit
{
   public partial class Form1 : Form
    {
        private Graphics area;
        private Brush brush;
        private int hoogte;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            celsiusTrackBar.Value = 0;
            brush = new SolidBrush(Color.Blue);
            hoogte = 5;
        }

        private void celsiusTrackBar_Scroll(object sender, EventArgs e)
        {
            tempPictureBox.Refresh(); // Verplicht de picturebox om zichzelf opnieuw te tekenen
        }

        private double CelsiusNaarFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        private void TekenWaarden(double c, double f)
        {
            area.Clear(Color.White);

            area.FillRectangle(brush, 25, 20, Convert.ToInt32(c), hoogte);
            area.FillRectangle(brush, 25, 40, Convert.ToInt32(f), hoogte);
        }

        private void tempPictureBox_Paint(object sender, PaintEventArgs e)
        {
           
            area = e.Graphics;
            TekenWaarden(celsiusTrackBar.Value, CelsiusNaarFahrenheit(celsiusTrackBar.Value));
        }
    }
}
