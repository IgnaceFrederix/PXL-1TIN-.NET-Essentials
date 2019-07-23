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

namespace Oef17_9_BankRekeningMetErrorProvider
{
    public partial class Form1 : Form
    {
        private Bankrekening myBankrekening;
        
        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            myBankrekening = new Bankrekening("123-123456-12", "Gilles Hermans");
            stortingOpnameTextBox.Text = Convert.ToString(0);
            saldoLabel.Text = Convert.ToString(0);
        }

        private void saldoButton_Click(System.Object sender, System.EventArgs e)
        {
            int bedrag = 0;
            bedrag = Convert.ToInt32(stortingOpnameTextBox.Text);
            ErrorProvider1.SetError(stortingOpnameTextBox, "");
            try
            {
                if (bedrag < 0)
                {
                    myBankrekening.Opname(-bedrag);
                }
                else
                {
                    myBankrekening.Storting(bedrag);
                }
                saldoLabel.Text = Convert.ToString(myBankrekening.Saldo);
            }
            catch (BankException ex)
            {
                ErrorProvider1.SetError(stortingOpnameTextBox, ex.Message);
            }
        }
    }
}
