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

namespace Oef13_10_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            colorComboBox_SelectedIndexChanged(null, null);
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = Convert.ToString(colorComboBox.SelectedItem);
            switch (selectedColor)
            {
                case "Red":
                    colorLabel.BackColor = Color.Red;
                    break;
                case "Green":
                    colorLabel.BackColor = Color.Green;
                    break;
                case "Blue":
                    colorLabel.BackColor = Color.Blue;
                    break;
            }

            //OF hiermee kan je eender welke kleur nog toevoegen aan de combobox
            //colorLabel.BackColor = Color.FromName(Convert.ToString(colorComboBox.SelectedItem));
        }
    }
}
