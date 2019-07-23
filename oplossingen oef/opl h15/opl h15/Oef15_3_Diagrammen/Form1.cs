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

namespace Oef15_3_Diagrammen
{
    public partial class Form1 : Form
    {
        private int[,] rainData = {{10, 7, 3, 28, 5, 6, 3},
                                  {12, 3, 5, 7, 12, 5, 8},
                                  {8, 5, 2, 1, 1, 4, 7}};

        public Form1()
        {
            InitializeComponent();
            Display();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void ChangeValue()
        {
            int dayNumber = Convert.ToInt32(dayTextBox.Text);
            int location = Convert.ToInt32(locationTextBox.Text);
            int dataValue = Convert.ToInt32(valueTextBox.Text);
            rainData[location, dayNumber] = dataValue;

            Display();
        }

        private void Display()
        {
            dataTextBox.Clear();

            for (int location = 0; location < 3; location++)
            {
                for (int dayNumber = 0; dayNumber < 7; dayNumber++)
                {
                    string line = String.Format("{0}\t", rainData[location, dayNumber]);
                    dataTextBox.AppendText(line);
                }
                dataTextBox.AppendText(Environment.NewLine);
            }
        }

        private void TekenStaafDiagram(PictureBox pbox, int[] rij)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics area = pbox.CreateGraphics();
            int u_width = Convert.ToInt32(pbox.Width / (rij.Length * 2 + 1));
            int u_height = Convert.ToInt32(pbox.Height / (Max(rij) * 1.2));
            // veronderstel dat de grootste waarde in de rij bijna de grootst mogelijke waarde is

            area.Clear(Color.White);
            for (int i = 0; i < rij.Length; i++)
            {
                area.FillRectangle(brush, (2 * i + 1) * u_width,
                                   pbox.Height - rij[i] * u_height,
                                   u_width, rij[i] * u_height);
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

        private void TekenCirkelDiagram(PictureBox pbox, int[] rij)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics area = pbox.CreateGraphics();
            Color[] kleuren = {
		                        Color.Red,
		                        Color.Blue,
		                        Color.Green,
		                        Color.Orange,
		                        Color.Purple,
		                        Color.Brown,
		                        Color.Bisque
	                        };

            int totaal = Som(rij);
            int hoek = 0;

            brush.Color = kleuren[0];
            int starthoek = Convert.ToInt32(360 * rij[0] / totaal);

            area.Clear(Color.White);

            area.FillPie(brush, 0, 0, pbox.Width, pbox.Height, 0, starthoek);

            for (int i = 1; i < rij.Length; i++)
            {
                brush.Color = kleuren[i];
                hoek = Convert.ToInt32(360 * rij[i] / totaal);
                area.FillPie(brush, 0, 0, pbox.Width, pbox.Height, starthoek, hoek);
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

        private void staafButton_Click(System.Object sender, System.EventArgs e)
        {
            int rij_index = Convert.ToInt32(rijTextBox.Text);

            int[] rij = new int[rainData.GetLength(1)];

            for (int i = 0; i < rij.Length; i++)
            {
                rij[i] = rainData[rij_index, i];
            }

            TekenStaafDiagram(chartPicturePox, rij);
        }

        private void cirkelButton_Click(System.Object sender, System.EventArgs e)
        {
            int rij_index = Convert.ToInt32(rijTextBox.Text);

            int[] rij = new int[rainData.GetLength(1)];

            for (int i = 0; i < rij.Length; i++)
            {
                rij[i] = rainData[rij_index, i];
            }

            TekenCirkelDiagram(chartPicturePox, rij);
        }
    }
}
