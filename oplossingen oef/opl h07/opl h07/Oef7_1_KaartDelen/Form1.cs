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

namespace Oef7_1_KaartDelen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaartButton_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            //Moet tussen 1 en 5 zijn, anders heb je nooit een schoppen
            int trek = randomNumber.Next(1, 5);
            string kleur = null;
            string getal = null;

            switch (trek)
            {
                case 1:
                    kleur = "harten";
                    break;
                case 2:
                    kleur = "ruiten";
                    break;
                case 3:
                    kleur = "klaveren";
                    break;
                case 4:
                    kleur = "schoppen";
                    break;
            }

            //Moet tussen 1 en 14 zijn, anders heb je nooit een koning
            trek = randomNumber.Next(1, 14);
           
            switch (trek)
            {
                case 1:
                    getal = "aas";
                    break;
                case 11:
                    getal = "boer";
                    break;
                case 12:
                    getal = "vrouw";
                    break;
                case 13:
                    getal = "koning";
                    break;
                default:
                    getal = Convert.ToString(trek);
                    break;
            }

            kaartTextBox.Text = kleur + "  " + getal;
        }
    }
}
