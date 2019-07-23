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

namespace Rainfall
{
    public partial class Form1 : Form
    {
        private int[] rain = { 7, 8, 0, 4, 3, 8, 1 };
         
        public Form1()
        {
            InitializeComponent();

            Display();
            Largest();
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
            Largest();
        }

        private void Largest()
        {
            int highest = rain[0];
            for (int index = 1; index < 7; index++)
            {
                if (highest < rain[index])
                {
                    highest = rain[index];
                }
            }
            largestLabel.Text = "Largest value is " + highest;
        }

        // Testvraag 14.7:
        //private void WeekTotal()
        //{
        //    int total = 0;
        //    foreach (int rainday in rain)
        //    {
        //        total += rainday;
        //    }
        //    totalLabel.Text = "Week total is: " + total; 
        //}
        
        private void changeButton_Click(object sender, EventArgs e)
        {
            NewValue();
        }

    }
}
