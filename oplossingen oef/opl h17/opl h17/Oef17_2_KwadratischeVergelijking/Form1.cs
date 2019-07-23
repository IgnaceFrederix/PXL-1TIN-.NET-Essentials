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

namespace Oef17_2_KwadratischeVergelijking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oplButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0;
                double b = 0;
                double c = 0;
                double opl1 = 0;
                double opl2 = 0;
                bool foutA = false;
                bool foutB = false;
                bool foutC = false;

                //oude resultaten verwijderen
                opl1Label.Text = "";
                opl2Label.Text = "";

                //oude errors verwijderen
                ErrorProvider1.SetError(aTextBox, "");
                ErrorProvider1.SetError(bTextBox, "");
                ErrorProvider1.SetError(cTextBox, "");

                foutA = false;
                foutB = false;
                foutC = false;
                
                if (aTextBox.Text == Convert.ToString(0))
                {
                    throw new ArithmeticException("a mag niet nul zijn; anders heb je een eerste graadsvergelijking!");
                }
                
                a = ControleerVeld(aTextBox, ref foutA);
                b = ControleerVeld(bTextBox, ref foutB);
                c = ControleerVeld(cTextBox, ref foutC);

                if ((!foutA) && (!foutB) && (!foutC))
                {
                    LosOp(a, b, c, ref opl1, ref opl2);
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double ControleerVeld(TextBox tekstBox, ref bool fout)
        {
            double getal = 0;

            try
            {
                getal = double.Parse(tekstBox.Text);
            }
            catch (FormatException exceptionObject)
            {
                fout = true;
                ErrorProvider1.SetError(tekstBox, exceptionObject.Message);
            }

            return getal;
        }

        private void LosOp(double a, double b, double c, ref double opl1, ref double opl2)
        {
            try
            {
                double discriminant = 0;
                discriminant = b * b - 4 * a * c;

                if (discriminant < 0)
                {
                    throw new ArithmeticException("Discriminant is negatief; vergelijking heeft geen reële oplossingen");
                }

                opl1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                opl2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                opl1Label.Text = String.Format("{0}",opl1);
                opl2Label.Text = String.Format("{0}",opl2);
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
