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

namespace Oef15_1_Gegevensverwerker
{
    public partial class Form1 : Form
    {
        private int[,] rainData = {{10, 7, 3, 28, 5, 6, 3},
                                  {12, 3, 5, 7, 12, 5, 8},
                                  {8, 5, 2, 1, 1, 4, 7}};

        private int[] sumLocation = new int[3];
        private int[] sumDay = new int[7];
        private int[] maxLocation = new int[3];
        private int[] maxDay = new int[7];

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
            CalculateTotal();
        }

        private void Display()
        {
            dataTextBox.Clear();

            for (int location = 0; location < rainData.GetLength(0); location++)
            {
                sumLocation[location] = 0;
            }

            for (int dayNumber = 0; dayNumber <= 6; dayNumber++)
            {
                sumDay[dayNumber] = 0;
            }

            for (int location = 0; location < 3; location++)
            {
                for (int dayNumber = 0; dayNumber < 7; dayNumber++)
                {
                    string line = String.Format("{0}\t", rainData[location, dayNumber]);
                    dataTextBox.AppendText(line);

                    sumLocation[location] += rainData[location, dayNumber];
                    sumDay[dayNumber] += rainData[location, dayNumber];

                    if (rainData[location, dayNumber] > maxLocation[location])
                    {
                        maxLocation[location] = rainData[location, dayNumber];
                    }

                    if (rainData[location, dayNumber] > maxDay[dayNumber])
                    {
                        maxDay[dayNumber] = rainData[location, dayNumber];
                    }
                }
                dataTextBox.AppendText(Environment.NewLine);
            }
        }

        private void CalculateTotal()
        {
            int total = 0;
            //for (int location = 0; location < 3; location++)
            //{
            //    for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            //    {
            //        total += rainData[location, dayNumber];
            //    }
            //}
            foreach (int item in rainData)
            {
                total += item;
            }
            totalLabel.Text = "Total rainfall is " + total;
        }

        private void totalButton_Click(System.Object sender, System.EventArgs e)
        {
            int location = 0;
            int dayNumber = 0;

            sumDayTextBox.Clear();
            sumLocationTextBox.Clear();

            for (location = 0; location < rainData.GetLength(0); location++)
            {
                sumLocationTextBox.AppendText(sumLocation[location] + "\r\n");
            }

            for (dayNumber = 0; dayNumber <= 6; dayNumber++)
            {
                sumDayTextBox.AppendText(sumDay[dayNumber] + "\t");
            }
        }

        private void largestButton_Click(object sender, EventArgs e)
        {
            int location = 0;
            int dayNumber = 0;

            sumDayTextBox.Clear();
            sumLocationTextBox.Clear();

            for (location = 0; location < rainData.GetLength(0); location++)
            {
                sumLocationTextBox.AppendText(maxLocation[location] + "\r\n");
            }

            for (dayNumber = 0; dayNumber <= 6; dayNumber++)
            {
                sumDayTextBox.AppendText(maxDay[dayNumber] + "\t");
            }
        }

        private void factorButton_Click(object sender, EventArgs e)
        {
            int location = 0;
            int dayNumber = 0;
            int factor = Convert.ToInt32(factorTextBox.Text);
            for (location = 0; location < rainData.GetLength(0); location++)
            {
                for (dayNumber = 0; dayNumber <= 6; dayNumber++)
                {
                    rainData[location, dayNumber] *= factor;
                }
            }
            Display();
        }
    }
}
