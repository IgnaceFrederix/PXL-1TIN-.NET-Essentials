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

namespace Oef14_8_Grafiekenprogramma
{
    public partial class Form1 : Form
    {
        private double[] x;
        private double[] y;

        //eenheidsfactor op de X-as
        private double unit_x;
        //eenheidsfactor op de Y-as
        private double unit_y;


        public Form1()
        {
            InitializeComponent();

            int hoogste_i = 10;
            
            // door te verhogen benader je beter en beter de sinus
            x = CreateX(hoogste_i);
            y = CreateY(x);

            unit_x = chartPictureBox.Width / (2 * Math.PI);
            unit_y = chartPictureBox.Height / 2;
            // sinus varieert van -1 tot +1
        }

        private void DrawGraph(double[] x, double[] y)
        {
            Graphics area = chartPictureBox.CreateGraphics();
            Pen p = new Pen(Color.Blue);
            Pen aspen = new Pen(Color.Red);

            //X-as
            area.DrawLine(aspen, 0,
                          Convert.ToInt32(chartPictureBox.Height / 2),
                          chartPictureBox.Width,
                          Convert.ToInt32(chartPictureBox.Height / 2));

            //y-as
            area.DrawLine(aspen, 0, 0, 0, chartPictureBox.Height);

            for (int i = 0; i < x.Length - 1; i++)
            {
                area.DrawLine(p, Convert.ToInt32(x[i] * unit_x),
                              Convert.ToInt32(chartPictureBox.Height / 2 - y[i] * unit_y),
                              Convert.ToInt32(x[i + 1] * unit_x),
                              Convert.ToInt32(chartPictureBox.Height / 2 - y[i + 1] * unit_y));
            }
        }

        private double[] CreateX(int n)
        {
            double[] x = new double[n + 1];
            for (int i = 0; i <= n; i++)
            {
                x[i] = i * 2 * Math.PI / n;
            }
            return x;
        }

        private double[] CreateY(double[] x)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = Math.Sin(x[i]);
            }
            return y;
        }

        private void drawButton_Click(System.Object sender, System.EventArgs e)
        {
            DrawGraph(x, y);
        }
    }
}
