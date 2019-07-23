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

namespace Multiple_Forms
{
    public partial class Form2 : Form
    {
        private Form otherForm;

        public Form2(Form other)
        {
            InitializeComponent();

            otherForm = other;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otherForm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otherForm.Show();
        }




    }
}
