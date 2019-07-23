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

namespace Oef10_3_Bankrekening
{
    public partial class Form1 : Form
    {
        private Bankrekening rekening;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            rekening = new Bankrekening();
            stortingOpnameTextBox.Text = "0";
            saldoLabel.Text = "0";
        }

        private void saldoButton_Click(object sender, EventArgs e)
        {
            int bedrag;
            bedrag = int.Parse(stortingOpnameTextBox.Text);
            if (bedrag < 0)
            {
                rekening.Opname((bedrag * -1));
            }
            else
            {
                rekening.Storting(bedrag);
            }
            saldoLabel.Text = rekening.HuidigSaldo.ToString();
            
            if ((int.Parse(saldoLabel.Text) < 0))
            {
                MessageBox.Show("Je staat in het rood!!!");
            }
        }
    }
}
