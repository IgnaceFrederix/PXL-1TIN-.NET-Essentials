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

namespace Oef10_2_Versterker
{
    public partial class Form1 : Form
    {
        private Versterker versterker;

        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            versterkerTrackBar.Value = 5;
            valueLabel.Text = Convert.ToString(versterkerTrackBar.Value);
            minLabel.Text = Convert.ToString(versterkerTrackBar.Value);
            maxLabel.Text = Convert.ToString(versterkerTrackBar.Value);
            versterker = new Versterker(versterkerTrackBar.Value);
        }

        private void versterkerTrackBar_Scroll(object sender, EventArgs e)
        {
            valueLabel.Text = Convert.ToString(versterkerTrackBar.Value);
            versterker.NieuweWaarde(versterkerTrackBar.Value);
            minLabel.Text = Convert.ToString(versterker.KleinsteWaarde);
            maxLabel.Text = Convert.ToString(versterker.GrootsteWaarde);
        }
    }
}
