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

namespace Oef7_7_Rekenmachine
{
    public partial class Form1 : Form
    {
        private int getal = 0;
        private int res = 0;
        private string vorigeOperator = "+";
        private string volgendeOperator;
        private bool nieuwGetal = true;

        public Form1()
        {
            InitializeComponent();
            
            TextBox1.Text = "0";
        }

        private void ButtonDigit_Click(object sender, System.EventArgs e)
        {
            MaakLeeg();
            TextBox1.AppendText(((Button)sender).Text);
        }

        private void ButtonOperator_Click(object sender, System.EventArgs e)
        {
            getal = Convert.ToInt32(TextBox1.Text);
            volgendeOperator = ((Button)sender).Text;
            Count();
        }

        private void Count()
        {
            switch (vorigeOperator)
            {
                case "+":
                    res = (res + getal);
                    break;
                case "-":
                    res = (res - getal);
                    break;
                default:
                    MessageBox.Show("Verkeerde operator");
                    break;
            }
            TextBox1.Text = Convert.ToString(res);
            if ((volgendeOperator == "="))
            {
                Initialiseer();
            }
            else
            {
                vorigeOperator = volgendeOperator;
            }
            nieuwGetal = true;
        }

        private void ButtonClear_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = "0";
            Initialiseer();
        }

        private void Initialiseer()
        {
            res = 0;
            vorigeOperator = "+";
        }

        private void MaakLeeg()
        {
            if (nieuwGetal)
            {
                TextBox1.Clear();
                nieuwGetal = false;
            }
        }
    }
}
