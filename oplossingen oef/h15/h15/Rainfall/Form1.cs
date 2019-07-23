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
            CalculateTotal();
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
    }
}
