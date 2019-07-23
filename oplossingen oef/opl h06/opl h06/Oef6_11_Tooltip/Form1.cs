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

namespace Oef6_11_Tooltip
{
    /// <summary>
    /// De property BeepOnError zorgt ervoor dat er een systeemgeluid wordt
    /// afgespeeld als een verkeerde toets wordt ingedrukt.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateMaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Ongeldige invoer";
            toolTip1.Show("Enkel cijfers zijn toegelaten in datumwaarden.", dateMaskedTextBox1, 50);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
