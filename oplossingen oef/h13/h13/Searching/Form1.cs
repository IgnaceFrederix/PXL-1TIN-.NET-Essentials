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

namespace Searching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void findButton_Click(object sender, EventArgs e)
        //{
        //    int length = shoppingListBox.Items.Count;
        //    int index = 0;
        //    bool found = false;
        //    string itemWanted = findTextBox.Text;

        //    while ((!found) && (index < length))
        //    {
        //        if (Convert.ToString(shoppingListBox.Items[index]) == itemWanted)
        //        {
        //            found = true;
        //            resultLabel.Text = "Item found, index: " + index;
        //        }
        //        else
        //        {
        //            index++;
        //        }
        //    }
        //}

        private void findButton_Click(object sender, EventArgs e)
        {
            string itemWanted = findTextBox.Text;
            if (shoppingListBox.Items.Contains(itemWanted))
            {
                resultLabel.Text = "Item found, index: " +
                    shoppingListBox.Items.IndexOf(itemWanted);
            }
        }
    }
}
