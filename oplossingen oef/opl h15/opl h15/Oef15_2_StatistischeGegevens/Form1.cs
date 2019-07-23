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

namespace Oef15_2_StatistischeGegevens
{
    public partial class Form1 : Form
    {
        private int[,] rainData = {{10, 7, 3, 28, 5, 6, 3},
                                  {12, 3, 5, 7, 12, 5, 8},
                                  {8, 5, 2, 1, 1, 4, 7}};

        private double[] avgPerDay = new double[7];
        private double[] avgPerLoc = new double[3];
        private double[] devPerDay = new double[7];
        private double[] devPerLoc = new double[3];

        public Form1()
        {
            InitializeComponent();
            AveragesAndDev();
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

            AveragesAndDev();
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

            foreach (double v in avgPerDay)
            {
                avgDayTextBox.AppendText(String.Format("{0:0.00}\t",v));
            }
            foreach (double v in avgPerLoc)
            {
                avgLocationTextBox.AppendText(String.Format("{0:0.00}\t", v));
            }
            foreach (double v in devPerDay)
            {
                devDayTextBox.AppendText(String.Format("{0:0.00}\t", v));
            }
            foreach (double v in devPerLoc)
            {
                devLocTextBox.AppendText(String.Format("{0:0.00}\t", v));
            }
        }

        private void AveragesAndDev()
        {
            // per dag

            // gemiddelden
            for (int dag = 0; dag < rainData.GetLength(1); dag++)
            {
                avgPerDay[dag] = 0;
                for (int loc = 0; loc < rainData.GetLength(0); loc++)
                {
                    avgPerDay[dag] += rainData[loc, dag];
                }
                avgPerDay[dag] = avgPerDay[dag] / rainData.GetLength(0);
            }

            // standaarddeviatie
            for (int dag = 0; dag < rainData.GetLength(1); dag++)
            {
                devPerDay[dag] = 0;
                for (int loc = 0; loc < rainData.GetLength(0); loc++)
                {
                    devPerDay[dag] = devPerDay[dag] + Math.Pow(rainData[loc, dag] - avgPerDay[dag], 2);
                }
                devPerDay[dag] = Math.Sqrt(devPerDay[dag] / rainData.GetLength(0));
            }



            // per locatie
            for (int loc = 0; loc < rainData.GetLength(0); loc++)
            {
                avgPerLoc[loc] = 0;
                for (int dag = 0; dag < rainData.GetLength(1); dag++)
                {
                    avgPerLoc[loc] += rainData[loc, dag];
                }
                avgPerLoc[loc] = avgPerLoc[loc] / rainData.GetLength(1);
            }

            for (int loc = 0; loc < rainData.GetLength(0); loc++)
            {
                devPerLoc[loc] = 0;
                for (int dag = 0; dag < rainData.GetLength(1); dag++)
                {
                    devPerLoc[loc] = devPerLoc[loc] + Math.Pow(rainData[loc, dag] - avgPerLoc[loc], 2);
                }
                devPerLoc[loc] = Math.Sqrt(devPerLoc[loc] / rainData.GetLength(1));
            }
        }

        private void avgButton_Click(object sender, EventArgs e)
        {
            AveragesAndDev();
            Display();
        }
    }
}
