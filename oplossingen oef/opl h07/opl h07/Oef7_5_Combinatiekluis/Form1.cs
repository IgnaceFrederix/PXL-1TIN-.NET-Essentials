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

namespace Oef7_5_Combinatiekluis
{
    public partial class Form1 : Form
    {
        private string trialCode = String.Empty;
        private string juisteCode = "111111";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Kluis(Convert.ToInt32(button1.Text));
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Kluis(Convert.ToInt32(button2.Text));
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Kluis(Convert.ToInt32(button3.Text));
        }

        private void Kluis(int digit)
        {
            trialCode = trialCode + digit;
            codeTextBox.AppendText(Convert.ToString(digit));
            if ((trialCode == juisteCode))
            {
                MessageBox.Show("U krijgt toegang!");
                wijzigButton.Visible = true;
            }
        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            trialCode = String.Empty;
            codeTextBox.Text = String.Empty;
        }

        private void buttonWijzig_Click(object sender, System.EventArgs e)
        {
            ZichtbaarOnzichtbaar(true);
        }

        private void ZichtbaarOnzichtbaar(bool waarde)
        {
            Label1.Visible = waarde;
            Label2.Visible = waarde;
            nieuweCodeTextBox.Visible = waarde;
            bevestigCodeTextBox.Visible = waarde;
            okButton.Visible = waarde;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if ((nieuweCodeTextBox.Text == bevestigCodeTextBox.Text))
            {
                juisteCode = nieuweCodeTextBox.Text;
                trialCode = String.Empty;
                MessageBox.Show("Nieuwe code aanvaard!");
                ZichtbaarOnzichtbaar(false);
                codeTextBox.Text = String.Empty;
                wijzigButton.Visible = false;
                nieuweCodeTextBox.Text = String.Empty;
                bevestigCodeTextBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("2 maal dezelfde code ingeven!");
            }
        }
    }
}
