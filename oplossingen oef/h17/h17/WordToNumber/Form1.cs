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

namespace WordToNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Convert.ToString(WordToNumber("hXndred")));
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show(exceptionObject.Message);
            }
        }

        private int WordToNumber(string word)
        {
            int result = 0;
            if (word == "ten")
            {
                result = 10;
            }
            else if (word == "hundred")
            {
                result = 100;
            }
            else if (word == "thousand")
            {
                result = 1000;
            }
            else
            {
                throw new FormatException("Wrong input: " + word);
            }
            return result;
        }
    }
}
