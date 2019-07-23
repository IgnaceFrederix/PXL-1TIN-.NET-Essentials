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

namespace Oef12_7_Belastingberekening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void belastingButton_Click(object sender, EventArgs e)
        {
            double inkomen;
            double belasting;
            inkomen = Convert.ToDouble(inkomenTextBox.Text);
            inkomenTextBox.Text = String.Format("{0:c}",inkomen);
            if (inkomen > 10000)
            {
                belasting = (inkomen - 10000) * 0.33;
            }
            else
            {
                belasting = 0;
            }
            LabelBelasting.Text = String.Format("{0:c}", belasting);
        }
    }
}
