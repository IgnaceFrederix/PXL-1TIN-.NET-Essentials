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

namespace Oef24_5_Rekeningen
{
    public partial class Form1 : Form
    {
        private Bankrekening myGewoneRekening;
        private Bankrekening myGoldenRekening;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            myGewoneRekening = new GewoneRekening(0, "Kris Hermans", "De Hoeven 66 bus 6, 3590 Diepenbeek");
            myGoldenRekening = new GoldenRekening(150, "Piet Verlinden", "Broekstraat 7, 3550 Heusden-Zolder");
            stortingOpnameTextBox.Text = Convert.ToString(0);
            saldoGewoonLabel.Text = Convert.ToString(myGewoneRekening.HuidigSaldo);
            saldoGoldenLabel.Text = Convert.ToString(myGoldenRekening.HuidigSaldo);
            gewoonLabel.Text = myGewoneRekening.Naam + ", " + myGewoneRekening.Adres;
            goldenLabel.Text = myGoldenRekening.Naam + ", " + myGoldenRekening.Adres;
            renteGewoonLabel.Text = String.Format("{0:0.00}", myGewoneRekening.BerekenRente());
            renteGoldenLabel.Text = String.Format("{0:0.00}", myGoldenRekening.BerekenRente());
        }

        private void ButtonSaldo_Click(System.Object sender, System.EventArgs e)
        {
            int bedrag = 0;
            bedrag = Convert.ToInt32(stortingOpnameTextBox.Text);
            try
            {
                if (bedrag < 0)
                {
                    myGewoneRekening.CreditSaldo(-bedrag);
                    myGoldenRekening.CreditSaldo(-bedrag);
                }
                else
                {
                    myGoldenRekening.DebetSaldo(bedrag);
                    myGewoneRekening.DebetSaldo(bedrag);
                }
            }
            catch (BankException ex)
            {
                MessageBox.Show(ex.Message);
            }

            saldoGewoonLabel.Text = Convert.ToString(myGewoneRekening.HuidigSaldo);
            saldoGoldenLabel.Text = Convert.ToString(myGoldenRekening.HuidigSaldo);
        }

        private void ButtonRente_Click(System.Object sender, System.EventArgs e)
        {
            renteGewoonLabel.Text = String.Format("{0:0.00}",myGewoneRekening.BerekenRente());
            renteGoldenLabel.Text = String.Format("{0:0.00}",myGoldenRekening.BerekenRente());
        }
    }
}
