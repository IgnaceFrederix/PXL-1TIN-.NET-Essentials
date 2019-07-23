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

namespace Amplifier
{
    public partial class Form1 : Form
    {
        private int max = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            int volume = volumeTrackBar.Value;
            if (volume > max)
            {
                max = volume;
            }
            messageLabel.Text = "maximum value is " + max;
        }
    }
}
