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

namespace Oef17_1_GeheleDeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            resultLabel.Text = "";
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            try
            {
                a = int.Parse(getalATextBox.Text);
                b = int.Parse(getalBTextBox.Text);

                resultLabel.Text = String.Format("a / b = {0} en b / a = {1}", a / b, b / a);
            }
            catch (FormatException ex)
            {
                resultLabel.Text = "Gelieve twee gehele getallen in te geven.";
            }
            catch (DivideByZeroException ex)
            {
                resultLabel.Text = "a noch b mogen 0 zijn.";
            }
        }
    }
}
