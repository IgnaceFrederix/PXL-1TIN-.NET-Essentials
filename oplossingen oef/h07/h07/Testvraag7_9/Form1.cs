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

namespace Testvraag7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = Convert(trackBar1.Value);
        }

        private string Convert(int s)
        {
            string suit = "";

            switch (s)
            {
                case 1:
                    suit = "ruiten";
                    break;
                case 2:
                    suit = "harten";
                    break;
                case 3:
                    suit= "klaveren";
                    break;
                case 4:
                    suit = "schoppen";
                    break;
            }
            return suit;
        }
    }
}
