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

namespace Oef23_2_Bankrekening
{
    public partial class Form1 : Form
    {
        private IBankrekening rekening;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            rekening = new Bankrekening("123-123456-12", "Gilles Hermans");
            stortingOpnameTextBox.Text = Convert.ToString(0);
            saldoLabel.Text = Convert.ToString(0);
        }

        private void saldoButton_Click(System.Object sender, System.EventArgs e)
        {
            int bedrag = 0;
            bedrag = Convert.ToInt32(stortingOpnameTextBox.Text);
            try
            {
                if (bedrag < 0)
                {
                    rekening.Opname(-bedrag);
                }
                else
                {
                    rekening.Storting(bedrag);
                }
                saldoLabel.Text = Convert.ToString(rekening.Saldo);
            }
            catch (BankException ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
