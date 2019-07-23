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

namespace Oef6_3_Random_Som_Gemiddelde
{
    /// <summary>
    /// Hoofdstuk 6, Oefening 3: Random - Som - Gemiddelde
    /// </summary>
    /// <remarks>
    ///   Deze oplossing gebruikt de functie format uit hoofdstuk 12. Evengoed
    ///   kan men de getallen voorstellen via <c>Convert.ToString</c>. <br />
    ///   </remarks>
    public partial class Form1 : Form
    {
        private double som;     // lopende som
        private double getal;   // willekeurig getal
        private double gem;     // lopend gemiddelde
        private int aantal;     // aantal keren geklikt
        private Random generator;
        private const int MIN = 200;
        
        public Form1()
        {
            InitializeComponent();
            aantal = 0;
            som = 0;
            gem = 0;
            generator = new Random();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            getal = MIN + generator.NextDouble() * MIN;
            som = som + getal;
            aantal = aantal + 1;
            gem = som / aantal;

            //voor meer uitlet over Format, zie hoofdstuk 12
            somTextbox.Text = String.Format("{0:F2}", som);
            gemiddeldeTextbox.Text = String.Format("{0:F2}", gem);
            randomTextbox.Text = String.Format("{0:F2}", getal);
        }
    }
}
