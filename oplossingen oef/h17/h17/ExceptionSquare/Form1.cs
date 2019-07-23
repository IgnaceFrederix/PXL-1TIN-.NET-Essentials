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
using System.Diagnostics;

namespace ExceptionSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double side;
            try
            {
                side = Double.Parse(sideTextBox.Text);
                statusLabel.Text = String.Format("Area is {0} square units.",
                                                 (side * side));
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
                statusLabel.Text = "Error in side, please re-enter.";
            }
        }

        //private void calculateButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DoCalc();
        //    }
        //    catch (FormatException exceptionObject)
        //    {
        //        statusLabel.Text = "Error in side, please re-enter.";
        //    }
        //}

        //private void DoCalc()
        //{
        //    double side = Double.Parse(sideTextBox.Text);
        //    statusLabel.Text = String.Format("Area is {0} square units.",
        //                                     (side * side));
        //}
    }
}
