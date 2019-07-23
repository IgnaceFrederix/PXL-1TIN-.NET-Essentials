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

namespace Oef16_8_EmailAdres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(System.Object sender, System.EventArgs e)
        {
            int i = 0;
            bool adres = true;
            string[] chars = {@" ", @"&", @"|", @"""", @"#", @"'", @"(", @"^", @"!", 
                                @"{", @"}", @")", @"-", @"_", @"<", @">", @"\", 
                                @",", @"?", @";", @":", @"/", @"=", @"+"};

            string[] lijst = new string[reservedListBox.Items.Count];

            if (emailTextBox.Text.IndexOf("@") == -1)
            {
                adres = false;
            }

            reservedListBox.Items.CopyTo(lijst, 0);

            while ((i < lijst.Length && adres))
            {
                if (emailTextBox.Text.IndexOf(lijst[i]) >= 0)
                {
                    adres = false;
                }
                i += 1;
            }

            i = 0;
            while ((i < chars.Length && adres))
            {
                if (emailTextBox.Text.IndexOf(chars[i]) >= 0)
                {
                    adres = false;
                }
                i += 1;
            }

            if (!adres)
            {
                MessageBox.Show("Geen geldig e-mailadres!");
            }
        }

        private void reservedButton_Click(System.Object sender, System.EventArgs e)
        {
            reservedListBox.Items.Add(reservedTextBox.Text);
        }
    }
}
