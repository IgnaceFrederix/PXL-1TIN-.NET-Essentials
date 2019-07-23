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

namespace Oef13_3_Clear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            itemListBox.Sorted = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            object obj = itemListBox.SelectedItem;
            if (obj != null)
                itemListBox.Items.Remove(obj);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.Add(itemTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
        }
    }
}
