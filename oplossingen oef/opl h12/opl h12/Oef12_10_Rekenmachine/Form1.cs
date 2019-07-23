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

namespace Oef12_10_Rekenmachine
{
    public partial class Form1 : Form
    {
        private double getal = 0;
        private double res = 0;
        private string vorigeOperator = "+";
        private string volgendeOperator;
        private bool nieuwGetal = true;
        private double graden;
        private Button knop;

        public Form1()
        {
            //  This call is required by the Windows Form Designer.
            InitializeComponent();
            //  Add any initialization after the InitializeComponent() call.
            Initialize();
        }

        private void Initialize()
        {
            displayTextBox.Text = "0";
        }

        private void Nummer_Click(object sender, System.EventArgs e)
        {
            MaakLeeg();
            knop = ((Button)(sender));
            displayTextBox.AppendText(knop.Text);
        }

        private void ButtonOperator_Click(object sender, System.EventArgs e)
        {
            knop = ((Button)(sender));
            Reken(knop.Text);
        }

        private void Reken(string bewerking)
        {
            getal = double.Parse(displayTextBox.Text);
            volgendeOperator = bewerking;
            switch (vorigeOperator)
            {
                case "+":
                    res = res + getal;
                    break;
                case "-":
                    res = res - getal;
                    break;
                case "*":
                    res = res * getal;
                    break;
                case "/":
                    res = res / getal;
                    // Bij deling door nul komt er automatisch oneindig (in het nederlands) te staan!
                    break;
            }
            displayTextBox.Text = res.ToString();
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

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            displayTextBox.Text = "0";
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
                displayTextBox.Clear();
                nieuwGetal = false;
            }
        }

        private void sinButton_Click(object sender, System.EventArgs e)
        {
            graden = double.Parse(displayTextBox.Text);
            displayTextBox.Text = Math.Sin(OmrekenenGraden(graden)).ToString();
        }

        private void cosButton_Click(object sender, System.EventArgs e)
        {
            graden = double.Parse(displayTextBox.Text);
            displayTextBox.Text = Math.Cos(OmrekenenGraden(graden)).ToString();
        }

        private double OmrekenenGraden(double graden)
        {
            nieuwGetal = true;
            return (graden / (180 * Math.PI));
        }

        private void lnButton_Click(object sender, System.EventArgs e)
        {
            displayTextBox.Text = Math.Log(double.Parse(displayTextBox.Text)).ToString();
            nieuwGetal = true;
        }

        private void sqrtButton_Click(object sender, System.EventArgs e)
        {
            displayTextBox.Text = Math.Sqrt(double.Parse(displayTextBox.Text)).ToString();
            nieuwGetal = true;
        }
    }
}
