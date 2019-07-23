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

namespace Oef11_3_Bankrekeningen
{
    public partial class Form1 : Form
    {
        private Bankrekening gewoon;
        private Bankrekening golden;
        
        public Form1()
        {
            InitializeComponent();

            gewoon = new GewoneRekening();
            golden = new GoldenRekening();
            stortingOpnameTextBox.Text = "0.0";
            saldoGewoonLabel.Text = "0.0";
            saldoGoldenLabel.Text = "0.0";
            renteGewoonLabel.Text = "0.0";
            renteGoldenLabel.Text = "0.0";
        }

        private void saldoButton_Click(object sender, EventArgs e)
        {
            double bedrag = Convert.ToDouble(stortingOpnameTextBox.Text);
            if (bedrag < 0)
            {
                gewoon.CreditSaldo(-bedrag);
                golden.CreditSaldo(-bedrag);
            }
            else
            {
                gewoon.DebetSaldo(bedrag);
                golden.DebetSaldo(bedrag);
            }
            saldoGewoonLabel.Text = String.Format("{0:0.00}", gewoon.Saldo);
            saldoGoldenLabel.Text = String.Format("{0:0.00}", golden.Saldo);

            if (gewoon.Saldo < 0)
            {
                MessageBox.Show("Je Gewone Rekening staat in het rood!!!");
            }
            if (golden.Saldo < 0)
            {
                MessageBox.Show("Je Golden Rekening staat in het rood!!!");
            }
        }

        private void renteButton_Click(object sender, EventArgs e)
        {
            renteGewoonLabel.Text = String.Format("{0:0.00}", gewoon.BerekenRente());
            renteGoldenLabel.Text = String.Format("{0:0.00}", golden.BerekenRente());
        }
    }
}
