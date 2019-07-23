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

namespace Oef13_9_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sourceCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetListBox.Items.Clear();
            for (int index = 0; index < sourceCheckedListBox.CheckedItems.Count; index++)
            {
                targetListBox.Items.Add(sourceCheckedListBox.CheckedItems[index]);
            }
        }
    }
}
