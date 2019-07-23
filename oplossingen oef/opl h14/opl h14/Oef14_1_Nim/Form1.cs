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

namespace Oef14_1_Nim
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        // we gebruiken progressbars voor de stapels
        private ProgressBar[] stapels = new ProgressBar[3];

        private Label[] labels = new Label[3];

        public Form1()
        {
            InitializeComponent();

            Initialiseer();
        }

        private void Initialiseer()
        {
            stapels[0] = stapel1ProgressBar;
            stapels[1] = stapel2ProgressBar;
            stapels[2] = stapel3ProgressBar;

            labels[0] = lblStapel1;
            labels[1] = lblStapel2;
            labels[2] = lblStapel3;


            for (int index = 0; index <= 2; index++)
            {
                stapels[index].Value = InitStapel();
                labels[index].Text = Convert.ToString(stapels[index].Value);
            }

            stapelComboBox.SelectedIndex = 0;
        }

        private int InitStapel()
        {
            return r.Next(1, 21);
        }

        private void verwijderButton_Click(System.Object sender, System.EventArgs e)
        {
            // we testen hier niet op de invoer
            int aantal = Convert.ToInt32(aantalTextBox.Text);

            string naamstapel = stapelComboBox.SelectedItem.ToString();
            int stapelindex = Convert.ToInt32(naamstapel.Last().ToString()) - 1;

            VerwijderLucifersVanStapel(aantal, stapelindex);

            // Als alle stapels nu nul zijn heeft de computer gewonnen
            if (stapel1ProgressBar.Value == 0 & stapel2ProgressBar.Value == 0 & stapel3ProgressBar.Value == 0)
            {
                MessageBox.Show("Computer heeft gewonnen", "Nim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
                // stop het spel
                // computer aan zet
            }
            else
            {
                string stapel = stapelComboBox.Items[r.Next(0, stapelComboBox.Items.Count)].ToString();
                stapelindex = Convert.ToInt32(stapel.Last().ToString()) - 1;
                aantal = KiesAantal(stapelindex);

                lblComputer.Text = "Verwijder " + Convert.ToString(aantal) + " van " + stapel;
                VerwijderLucifersVanStapel(aantal, stapelindex);

                // Als alle stapels nu nul zijn heeft de speler gewonnen
                if (stapel1ProgressBar.Value == 0 & stapel2ProgressBar.Value == 0 & stapel3ProgressBar.Value == 0)
                {
                    MessageBox.Show("Speler heeft gewonnen", "Nim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }

        private int KiesAantal(int index)
        {
            return r.Next(1, stapels[index].Value + 1);
        }

        private void VerwijderLucifersVanStapel(int aantal, int i)
        {
            stapels[i].Value = Convert.ToInt32((stapels[i].Value - aantal < 0 ? 0 : stapels[i].Value - aantal));
            labels[i].Text = Convert.ToString(stapels[i].Value);
            if (stapels[i].Value == 0)
            {
                stapelComboBox.Items.Remove("Stapel " + (i + 1));
            }
        }
    }
}
