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

namespace Oef21_1_Kaartnummer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void methode1Button_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                int nummer = int.Parse(nummerTextBox.Text);
                string str = null;
                if (nummer == 1)
                {
                    str = "Ruiten";
                }
                else if (nummer == 2)
                {
                    str = "Klaveren";
                }
                else if (nummer == 3)
                {
                    str = "Schoppen";
                }
                else if (nummer == 4)
                {
                    str = "Harten";
                }
                else
                {
                    str = "gelieve een getal tussen 1 en 4 te geven";
                }
                MessageBox.Show(str);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("gelieve een getal tussen 1 en 4 te geven");
            }
        }


        private void methode2Button_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                int nummer = int.Parse(nummerTextBox.Text);
                string str = "gelieve een getal tussen 1 en 4 te geven";
                if (nummer == 1)
                {
                    str = "Ruiten";
                }
                if (nummer == 2)
                {
                    str = "Klaveren";
                }
                if (nummer == 3)
                {
                    str = "Schoppen";
                }
                if (nummer == 4)
                {
                    str = "Harten";
                }

                MessageBox.Show(str);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("gelieve een getal tussen 1 en 4 te geven");
            }
        }

        private void methode3Button_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                int nummer = int.Parse(nummerTextBox.Text);
                string str = null;
                if (nummer == 1)
                {
                    str = "Ruiten";
                }
                else if (nummer == 2)
                {
                    str = "Klaveren";
                }
                else if (nummer == 3)
                {
                    str = "Schoppen";
                }
                else if (nummer == 4)
                {
                    str = "Harten";
                }
                else
                {
                    str = "gelieve een getal tussen 1 en 4 te geven";
                }
                MessageBox.Show(str);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("gelieve een getal tussen 1 en 4 te geven");
            }
        }


        private void methode4Button_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                int nummer = int.Parse(nummerTextBox.Text);
                string str = null;

                switch (nummer)
                {
                    case 1:
                        str = "Ruiten";
                        break;
                    case 2:
                        str = "Klaveren";
                        break;
                    case 3:
                        str = "Schoppen";
                        break;
                    case 4:
                        str = "Harten";
                        break;
                    default:
                        str = "gelieve een getal tussen 1 en 4 te geven";
                        break;
                }

                MessageBox.Show(str);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("gelieve een getal tussen 1 en 4 te geven");
            }
        }
    }
}
