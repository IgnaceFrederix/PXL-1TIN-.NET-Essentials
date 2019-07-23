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

namespace Oef7_11_Pseudo_Random
{
    /// <summary>
    /// Hoofdstuk 7, oefening 11: Pseudo-random
    /// </summary>
    /// <remarks>
    /// Je stelt vast dat de beide knoppen dezelfde reeks getallen produceren.
    /// Twee objecten die met dezelfde seed-waarde worden geïnitialiseerd zullen 
    /// eenzelfde sequentie van getallen produceren.
    /// Je kan dit verhelpen door de seed-waarde in de constructor voor beide
    /// generatoren verschillend te maken.
    /// </remarks>
    public partial class Form1 : Form
    {
        private Random rand1;
        private Random rand2;
        
        // Mogelijk oplossing
        //private int seed = DateTime.Now.Millisecond;

        public Form1()
        {
            InitializeComponent();
            rand1 = new Random(5000);
            rand2 = new Random(5000);

            // Mogelijk oplossing
            //rand1 = new Random(seed);
            //seed = seed + new Random().Next(1, 1000);
            //rand2 = new Random(seed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(rand1.Next());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(rand2.Next());
        }
    }
}
