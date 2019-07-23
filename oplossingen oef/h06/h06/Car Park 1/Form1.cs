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

namespace Car_Park_1
{
    public partial class Form1 : Form
    {
        private int carCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            carCount = carCount + 1;
            countLabel.Text = Convert.ToString(carCount);
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            carCount = carCount - 1;
            countLabel.Text = Convert.ToString(carCount);   
        }
    }
}
