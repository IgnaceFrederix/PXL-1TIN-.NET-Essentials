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

namespace Oef14_2_Kluiscombinatie
{
    public partial class Form1 : Form
    {
        private int[] correct = {1, 2, 3, 4, 5, 6};
        private int verkeerdeGokken = 0;
        private int index = -1;

        private int[] ingave = new int[6];

        public Form1()
        {
            InitializeComponent();

            ToonIngave();
        }


        private void Button_Click(object sender, EventArgs e)
        {
            index = index + 1;
            ingave[index] = Convert.ToInt32(((Button)sender).Text);
            ToonIngave();

            if (ingave[index] != correct[index])
            {
                verkeerdeGokken = verkeerdeGokken + 1;
                index = index - 1;
                if (verkeerdeGokken == 3)
                {
                    MessageBox.Show("U heeft 3 fouten gemaakt, opnieuw beginnen");
                    verkeerdeGokken = 0;
                    index = -1;
                    ToonIngave();
                }
                else
                {
                    MessageBox.Show("Foute ingave, nog " + Convert.ToString(3 - verkeerdeGokken) + " resterende pogingen");
                }
            }
            else
            {
                if (index == 5)
                {
                    MessageBox.Show("Proficiat, u hebt de kluis geopend");
                    verkeerdeGokken = 0;
                    index = -1;
                    ToonIngave();
                }
            }
        }

        private void ToonIngave()
        {
            codeLabel.Text = string.Empty;
            for (int i = 0; i <= index; i++)
            {
                codeLabel.Text = codeLabel.Text + Convert.ToString(ingave[i]);
            }
            for (int i = index + 1; i < correct.Length; i++)
            {
                codeLabel.Text = codeLabel.Text + "-";
            }
        }
    }
}
