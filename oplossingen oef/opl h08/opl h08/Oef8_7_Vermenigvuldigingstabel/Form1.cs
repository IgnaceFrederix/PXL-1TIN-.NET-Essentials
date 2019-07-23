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

namespace Oef8_7_Vermenigvuldigingstabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(sizeTextBox.Text);
            tableTextBox.Clear();

            tableTextBox.AppendText("\t");
            for (int headingNumber = 1; headingNumber <= size; headingNumber++)
            {
                tableTextBox.AppendText(headingNumber + "\t");
            }
            tableTextBox.AppendText(Environment.NewLine);
            tableTextBox.AppendText(Environment.NewLine);

            for (int row = 1; row <= size; row++)
            {
                tableTextBox.AppendText(row + "\t");
                for (int col = 1; col <= size; col++)
                {
                    tableTextBox.AppendText((row * col) + "\t");
                }
                tableTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
