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

namespace Oef14_12_Woordenboek
{
    public partial class Form1 : Form
    {
        private string[] tabel1 = {"file", "open", "close", "save", "save as", 
                                      "edit", "cut", "copy", "paste"};
        private string[] tabel2 = {"bestand", "openen", "sluiten", "opslaan", "opslaan als", 
                                  "bewerk", "knippen", "kopiëren", "plakken"};

        public Form1()
        {
            InitializeComponent();
        }
        
        private void zoekButton_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            bool found = false;
            for (i = 0; (i < tabel1.Length && !found); i++)
            {
                if (en_nlRadioButton.Checked)
                {
                    if (tabel1[i] == zoekStringTextBox.Text)
                    {
                        vertalingLabel.Text = tabel2[i];
                        found = true;
                    }
                }
                else if (tabel2[i] == zoekStringTextBox.Text)
                {
                    vertalingLabel.Text = tabel1[i];
                    found = true;
                }
            }
            if (!found)
            {
                vertalingLabel.Text = "?";
            }
        }
    }
}
