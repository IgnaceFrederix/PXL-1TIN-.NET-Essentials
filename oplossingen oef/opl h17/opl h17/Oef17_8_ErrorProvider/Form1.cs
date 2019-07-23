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

namespace Oef17_8_ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                mailErrorProvider.Clear();
                CheckAddress(mailTextBox.Text);
            }
            catch (Exception ex)
            {
                mailErrorProvider.SetError(mailTextBox, ex.Message);
            }
        }

        private void CheckAddress(string email)
        {
            if (!email.Contains('@'))
            {
                throw new InvalidMailException(email + " does not contain @-sign!");
            }
        }
    }
}
