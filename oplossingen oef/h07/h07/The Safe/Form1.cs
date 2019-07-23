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

namespace The_Safe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unlockButton_Click(object sender,
                                        EventArgs e)
        {
            string code;

            statusLabel.Text = "";
            code = codeTextBox.Text;

            if (code == "bill")
            {
                statusLabel.Text = "Unlocked";
            }
        }
    }
}
