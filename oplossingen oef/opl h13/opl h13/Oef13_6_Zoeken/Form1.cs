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

namespace Oef13_6_Zoeken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (itemListBox.Items.Contains(findTextBox.Text))
            {
                string msg = String.Format("Item gevonden op positie {0}",
                                itemListBox.Items.IndexOf(findTextBox.Text));
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Item niet gevonden");
            }
        }
    }
}
