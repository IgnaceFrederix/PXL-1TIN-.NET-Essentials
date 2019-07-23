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

namespace Oef14_13_Bibliotheekcode
{
    public partial class Form1 : Form
    {
        private int[] codes = { 100, 989, 456, 444 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            if ((IndexOf(int.Parse(txtCode.Text), codes) == -1))
            {
                MessageBox.Show("Code niet correct, toegang gewijgerd");
            }
            else
            {
                MessageBox.Show("Code ok");
            }
        }

        private int IndexOf(int val, int[] rij)
        {
            int i = -1;
            int j = 0;
            while ((j < rij.Length) && (rij[j] != val))
            {
                j = (j + 1);
            }
            if (j < rij.Length)
            {
                i = j;
            }
            return i;
        }
    }
}
