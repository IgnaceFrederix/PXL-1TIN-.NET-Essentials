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

namespace Oef7_9_Nim
{
    // Dit is een basisversie die het spel implementeert zonder al te veel controles op invoer (ongeldige waarden)
    // Voor meer info over een optimale strategie om dit spel te spelen:
    // http://nl.wikipedia.org/wiki/Nim_(spel)
    public partial class Form1 : Form
    {
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            Initialiseer();
        }

        private void Initialiseer()
        {
            pbStapel1.Value = InitStapel();
            lblStapel1.Text = Convert.ToString(pbStapel1.Value);
            pbStapel2.Value = InitStapel();
            lblStapel2.Text = Convert.ToString(pbStapel2.Value);
            pbStapel3.Value = InitStapel();
            lblStapel3.Text = Convert.ToString(pbStapel3.Value);
            cbStapel.SelectedIndex = 0;
        }

        private int InitStapel()
        {
            return r.Next(1, 201);
        }

        private void btnVerwijder_Click(object sender, System.EventArgs e)
        {
            //  we testen hier niet op de invoer
            int aantal = Convert.ToInt32(txtAantal.Text);
            VerwijderLucifersVanStapel(aantal, cbStapel.SelectedItem.ToString());
            //  Als alle stapels nu nul zijn heeft de computer gewonnen
            if ((pbStapel1.Value == 0) && (pbStapel2.Value == 0) && (pbStapel3.Value == 0))
            {
                MessageBox.Show("Computer heeft gewonnen",
                                "Nim",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Environment.Exit(0);
                //  stop het spel
            }
            else
            {
                //  computer aan zet
                string stapel = cbStapel.Items[r.Next(0, cbStapel.Items.Count)].ToString();
                aantal = KiesAantal(stapel);
                lblComputer.Text = String.Format("Verwijder {0} van {1}", aantal, stapel);
                VerwijderLucifersVanStapel(aantal, stapel);
                //  Als alle stapels nu nul zijn heeft de speler gewonnen
                if ((pbStapel1.Value == 0) && (pbStapel2.Value == 0) && (pbStapel3.Value == 0))
                {
                    MessageBox.Show("Speler heeft gewonnen", "Nim",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }

        private int KiesAantal(string stapel)
        {
            if ((stapel == "Stapel 1"))
            {
                return r.Next(1, (pbStapel1.Value + 1));
            }
            if ((stapel == "Stapel 2"))
            {
                return r.Next(1, (pbStapel2.Value + 1));
            }
            if ((stapel == "Stapel 3"))
            {
                return r.Next(1, (pbStapel3.Value + 1));
            }
            return 0;
        }

        private void VerwijderLucifersVanStapel(int aantal, string stapel)
        {
            if ((stapel == "Stapel 1"))
            {
                pbStapel1.Value = ((pbStapel1.Value - aantal) < 0 ? 0 : (pbStapel1.Value - aantal));
                lblStapel1.Text = Convert.ToString(pbStapel1.Value);
                if ((pbStapel1.Value == 0))
                {
                    cbStapel.Items.Remove("Stapel 1");
                    if (cbStapel.Items.Count != 0)
                    {
                        cbStapel.SelectedIndex = 0;
                    }
                }
            }
            else if ((stapel == "Stapel 2"))
            {
                pbStapel2.Value = ((pbStapel2.Value - aantal) < 0 ? 0 : (pbStapel2.Value - aantal));
                lblStapel2.Text = Convert.ToString(pbStapel2.Value);
                if ((pbStapel2.Value == 0))
                {
                    cbStapel.Items.Remove("Stapel 2");
                    if (cbStapel.Items.Count != 0)
                    {
                        cbStapel.SelectedIndex = 0;
                    }
                }
            }
            else if ((stapel == "Stapel 3"))
            {
                pbStapel3.Value = ((pbStapel3.Value - aantal) < 0 ? 0 : (pbStapel3.Value - aantal));
                lblStapel3.Text = Convert.ToString(pbStapel3.Value);
                if ((pbStapel3.Value == 0))
                {
                    cbStapel.Items.Remove("Stapel 3");
                    if (cbStapel.Items.Count != 0)
                    {
                        cbStapel.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}
