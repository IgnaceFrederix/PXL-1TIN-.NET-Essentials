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

namespace Oef13_5_ToevoegenVerwijderen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //itemListBox.Sorted = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.RemoveAt(Convert.ToInt32(posTextBox.Text));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.Insert(Convert.ToInt32(posTextBox.Text),itemTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            int index = itemListBox.SelectedIndex;
            if (index > -1)
            {
                itemListBox.Items.RemoveAt(index);
                itemListBox.Items.Insert(index, replaceTextBox.Text);
            }
        }
    }
}
