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
using Microsoft.VisualBasic; // ook add reference!

//omdat dit een heel gedoe is (VB dll toevoegen)
//heb ik dit niet in het boek opgenomen
namespace InputBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            string s;
            s = Microsoft.VisualBasic.Interaction.InputBox("Enter your name");
            n = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your age"));
            label1.Text = "Hi, " + s + ", you are " + n + " years old";
        }
    }
}
