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

namespace Oef2_7_Dubbelklik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // event handler toevoegen via de properties is niet mogelijk
            // Merk echter op dat dit event op een button zinloos is
            // vermits het click-event voorrang krijgt.
            button1.DoubleClick += button1_DoubleClick;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Dubbelklik op het label");
        }

        private void button1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Dubbelklik op de button");
        }
    }
}
