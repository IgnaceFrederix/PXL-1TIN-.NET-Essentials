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

namespace Oef12_9_Vierkantswortel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            double getal = Convert.ToDouble(getalTextBox.Text);
            double exact = Math.Sqrt(getal);
            int i = 1;
            benaderingTextBox.Clear();
            exactTextBox.Text = Convert.ToString(exact);
            double benadering = (getal / 2);
            //  eerste benadering
            benaderingTextBox.AppendText(String.Format("Benadering {0} : {1}\r\n",i, benadering));
            //  We gaan voor 3 cijfers nauwkeurigheid
            while (Math.Abs(exact - benadering) > 0.001)
            {
                benadering = (benadering + (getal / benadering)) / 2;
                i = i + 1;
                benaderingTextBox.AppendText(String.Format("Benadering {0} : {1}\r\n", i, benadering));
            }
        }
    }
}
