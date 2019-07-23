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

namespace Oef14_17_Telefoongids
{
    public partial class Form1 : Form
    {
        private Entry[] directory = new Entry[1001];
        
        //eerste vrije plaats
        private int n;


        public Form1()
        {
            InitializeComponent();

            directory[0] = new Entry();
            directory[0].Name = "Douglas Bell";
            directory[0].Number = "01 0114 253 3103";
            n = 1;
        }

        private void voegToeButton_Click(System.Object sender, System.EventArgs e)
        {
            if (n == directory.Length)
            {
                MessageBox.Show("Sorry, memory full");
            }
            else
            {
                directory[n] = new Entry();
                directory[n].Name = naamTextBox.Text;
                directory[n].Number = nummerTextBox.Text;
                n = n + 1;
            }
        }


        private void zoekButton_Click(System.Object sender, System.EventArgs e)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                if (directory[i].Name == naamTextBox.Text)
                {
                    MessageBox.Show("nummer = " + directory[i].Number);
                    return;
                }
            }
            MessageBox.Show("Nummer niet gevonden");
        }
    }
}