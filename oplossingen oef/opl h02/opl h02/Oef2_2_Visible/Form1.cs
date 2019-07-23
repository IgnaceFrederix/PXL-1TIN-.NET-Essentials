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

namespace Oef2_2_Visible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void visibleButton_Click(object sender, EventArgs e)
        {
            coloredLabel.Visible = true;
        }

        private void invisibleButton_Click(object sender, EventArgs e)
        {
            coloredLabel.Visible = false;
        }
    }
}