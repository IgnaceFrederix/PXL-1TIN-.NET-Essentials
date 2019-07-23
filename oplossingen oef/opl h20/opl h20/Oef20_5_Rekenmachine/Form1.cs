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

namespace Oef20_5_Rekenmachine
{
    public partial class Form1 : Form
    {
        private Calculator myCalc;

        public Form1()
        {
            InitializeComponent();
            myCalc = new Calculator();
            calcTextBox.Text = myCalc.Display;
        }

        private void ButtonDigit_Click(System.Object sender, System.EventArgs e)
        {
            myCalc.EnterDigit(((Button)sender).Text);
            calcTextBox.Text = myCalc.Display;
        }

        private void ButtonOperator_Click(System.Object sender, System.EventArgs e)
        {
            myCalc.EnterOperator(((Button)sender).Text);
            calcTextBox.Text = myCalc.Display;
        }

        private void ButtonClear_Click(System.Object sender, System.EventArgs e)
        {
            myCalc.Reset();
            calcTextBox.Text = myCalc.Display;
        }
    }
}
