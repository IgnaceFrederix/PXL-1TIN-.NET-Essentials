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

namespace Oef14_14_Telefoongids
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

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            int index = 0;
            string wanted = null;

            wanted = TextBox1.Text;
            index = 0;
            while ((names[index] != wanted) && (names[index] != "END"))
            {
                index = index + 1;
            }

            if (names[index] == wanted)
            {
                Label1.Text = "number is " + numbers[index];
            }
            else
            {
                Label1.Text = "name not found";
            }
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            if (names[names.Length - 1] == "END")
            {
                MessageBox.Show("Sorry, memory is full");
            }
            else
            {
                int i = 0;
                while (names[i] != "END")
                {
                    i = i + 1;
                }
                names[i] = txtName.Text;
                numbers[i] = txtNumber.Text;

                names[i + 1] = "END";
            }
        }

        //Verwijder het element aangegeven in TextBox1
        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            int index = 0;
            string wanted = null;

            wanted = TextBox1.Text;
            index = 0;
            while ((names[index] != wanted) && (names[index] != "END"))
            {
                index = index + 1;
            }
            if (names[index] == wanted)
            {
                Label1.Text = "number is " + numbers[index] + " is deleted";
                for (int i = index; i < names.Length - 1; i++)
                {
                    names[i] = names[i + 1];
                    numbers[i] = numbers[i + 1];
                }
            }
            else
            {
                Label1.Text = "name not found";
            }
        }
    }
}
