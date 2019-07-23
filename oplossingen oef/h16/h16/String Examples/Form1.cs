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

namespace String_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string string1 = string1TextBox.Text;
            string string2 = string2TextBox.Text;
            int m, n;

            // place example code here
            string resultString = "";
            string[] words;
            char[] separators = { ',' };
            words = string1.Split(separators);
            for (int place = 0; place < words.Length; place++)
            {
                resultString += "[" + words[place].Trim() + "] ";
            }

            resultLabel.Text = resultString;
        }
    }
}
