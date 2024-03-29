﻿//-----------------------------------------------------------------------------
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

namespace Oef13_1_VerwijderItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = listBox1.SelectedItem;
            if (obj != null)
                listBox1.Items.Remove(obj);
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            object obj = listBox2.SelectedItem;
            if (obj != null)
                listBox2.Items.Remove(obj);
        }
    }
}
