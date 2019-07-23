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

namespace Oef6_12_Progressbar
{
    /// <summary>
    /// Hoofdstuk 6, oefening 12: progressbar
    /// </summary>
    /// <remarks>
    /// <list>
    /// <item>Typisch gebruik: indicatie van voortgang voor de gebruiker</item>
    /// <item>properties voor minimumwaarde, maximumwaarde, huidige waarde: Minimum, Maximum, Value</item>
    /// </list>
    /// </remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                OKButton.Enabled = false;
                MessageBox.Show("U heeft slechts 5 seconden om in te loggen!");
            }
            else
            {
                progressBar1.Value += 20;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }
    }
}
