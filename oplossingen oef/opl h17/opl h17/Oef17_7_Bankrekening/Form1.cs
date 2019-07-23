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

namespace Oef17_7_Bankrekening
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
            rekening = new Bankrekening("123-123456-12", "Gilles Hermans");
            bedragTextBox.Text = "0";
            saldoLabel.Text = "0";
        }

        private void saldoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bedrag = int.Parse(bedragTextBox.Text);
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
            catch (FormatException ex)
            {
                MessageBox.Show("Gelieve een geheel getal in het bedrag-veld in te vullen.");
            }
            catch (BankException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
