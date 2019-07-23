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

namespace MeerdereCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int bottom;
            int top = 100;
            try
            {
                bottom = Int32.Parse(bottomTextBox.Text);
                statusLabel.Text = String.Format("Dividing into 100 gives {0}",
                                                 (top / bottom));
            }
            catch (DivideByZeroException exceptionObject)
            {
                statusLabel.Text = "Error - zero: re-enter data.";
            }
            catch (FormatException exceptionObject)
            {
                statusLabel.Text = "Error in number: re-enter.";
            }
            catch (SystemException exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
    }
}
