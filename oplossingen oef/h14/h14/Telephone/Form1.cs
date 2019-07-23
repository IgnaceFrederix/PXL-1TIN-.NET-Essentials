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

namespace Telephone
{
    public partial class Form1 : Form
    {
        private string[] names = new string[20];
        private string[] numbers = new string[20];

        public Form1()
        {
            InitializeComponent();

            names[0] = "Alex";
            numbers[0] = "2720774";

            names[1] = "Megan";
            numbers[1] = "5678554";

            names[2] = "END";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            int index = 0;
            string wanted = nameTextBox.Text;

            while (names[index] != wanted && (names[index] != "END"))
            {
                index++;
            }
            if (names[index] == wanted)
            {
                resultLabel.Text = "Number is " + numbers[index];
            }
            else
            {
                resultLabel.Text = "Name not found";
            }
        }
    }
}
