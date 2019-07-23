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

namespace Fast_Food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            foodLabel.Visible = true;
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            foodLabel.Visible = false;
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            //if (foodLabel.Visible)
            //{
            //    foodLabel.Visible = false;
            //}
            //else
            //{
            //    foodLabel.Visible = true;
            //}
            foodLabel.Visible = !foodLabel.Visible;
        }


    }
}
