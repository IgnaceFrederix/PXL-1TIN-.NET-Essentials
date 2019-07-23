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

namespace Oef5_13_DecNaarBin
{
    /// <summary>
    /// Hoofdstuk 5, oefening 13:
    /// Deze functie zet een decimaal getal om naar een binair getal
    /// </summary>
    /// <param name="waarde">een decimaal getal tussen 0 en 255</param>
    /// <returns>een binair getal als string</returns>
    /// <remarks>
    /// Er worden geen extra controles op de parameter <c>waarde</c> gedaan
    /// </remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(numberTextBox.Text);
            binLabel.Text = DecNaarBin(amount);
        }

        private string DecNaarBin(int waarde)
        {
            string result = String.Empty;
            int amount = Convert.ToInt32(numberTextBox.Text);
            int division;

            division = amount / 128;
            amount = amount % 128;
            result = result + division;

            division = amount / 64;
            amount = amount % 64;
            result = result + division;

            division = amount / 32;
            amount = amount % 32;
            result = result + division;

            division = amount / 16;
            amount = amount % 16;
            result = result + division;

            division = amount / 8;
            amount = amount % 8;
            result = result + division;

            division = amount / 4;
            amount = amount % 4;
            result = result + division;

            division = amount / 2;
            amount = amount % 2;
            result = result + division + amount;

            return result;
        }
    }
}
