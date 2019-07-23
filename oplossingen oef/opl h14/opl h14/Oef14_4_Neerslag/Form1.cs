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

namespace Oef14_4_Neerslag
{
    public partial class Form1 : Form
    {
        private int[] rain = { 7, 8, 0, 4, 3, 8, 1 };
         
        public Form1()
        {
            InitializeComponent();

            Display();
            WeekTotal();
            MinMax();

            valueTextBox.Text = Convert.ToString(rain[0]);
        }

        private void Display()
        {
            rainfallTextBox.Clear();
            for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            {
                string line = String.Format("day {0} rain {1}",
                                            dayNumber,
                                            rain[dayNumber]);
                rainfallTextBox.AppendText(line);
                rainfallTextBox.AppendText(Environment.NewLine);
            }
        }

        private void NewValue()
        {
            int index = Convert.ToInt32(indexTextBox.Text);
            int data = Convert.ToInt32(valueTextBox.Text);
            rain[index] = data;
            Display();
            MinMax();
        }

        private void WeekTotal()
        {
            int total = 0;
            foreach (int rainday in rain)
            {
                total += rainday;
            }
            labelTotal.Text = "Week total is: " + total; 
        }

        private void MinMax()
        {
            int min = rain[0];
            int max = rain[0];
            int max_index = 0;

            for (int i = 1; i < rain.Length; i++)
            {
                if (rain[i] > max)
                {
                    max = rain[i];
                    max_index = i;
                }
                if (rain[i] < min)
                {
                    min = rain[i];
                }
            }

            maxLabel.Text = "Largest Value: " + Convert.ToString(max) + " at index " + Convert.ToString(max_index);
            minLabel.Text = "Smallest Value: " + Convert.ToString(min);
        }

        
        private void changeButton_Click(object sender, EventArgs e)
        {
            NewValue();
        }

    }
}
