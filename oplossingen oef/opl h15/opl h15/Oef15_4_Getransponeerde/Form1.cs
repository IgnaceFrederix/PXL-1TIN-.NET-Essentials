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

namespace Oef15_4_Getransponeerde
{
    public partial class Form1 : Form
    {
        private int[,] table =  {{1, 2, 3, 4}, 
                                 {5, 6, 7, 8}, 
                                 {9, 10, 11, 12}, 
                                 {13, 14, 15, 16}};
        private int[,] table2;
        
        public Form1()
        {
            InitializeComponent();

            table2 = new int[table.GetLength(1), table.GetLength(0)];

            Display();
        }
 
        private void Display()
        {
            int i = 0;
            int j = 0;
            matrixTextBox.Clear();
            for (i = 0; i < table.GetLength(0); i++)
            {
                for (j = 0; j < table.GetLength(1); j++)
                {
                    matrixTextBox.AppendText(table[i, j] + "\t");
                }
                matrixTextBox.AppendText("\r\n");
            }
        }

        private void transponeerButton_Click(System.Object sender, System.EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < table2.GetLength(0); i++)
            {
                for (j = 0; j < table2.GetLength(1); j++)
                {
                    table2[i, j] = table[j, i];
                }
            }
            DisplayGetransponeerde();
        }

        private void DisplayGetransponeerde()
        {
            int i = 0;
            int j = 0;
            transposeTextox.Clear();
            for (i = 0; i < table2.GetLength(0); i++)
            {
                for (j = 0; j < table2.GetLength(1); j++)
                {
                    transposeTextox.AppendText(table2[i, j] + "\t");
                }
                transposeTextox.AppendText("\r\n");
            }
        }
    }
}
