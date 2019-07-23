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

namespace Oef7_6_SteenSchaarPapier
{
    public partial class Form1 : Form
    {
        private int teller = 0;

        public Form1()
        {
            InitializeComponent();
            steenButton.Click += Button_Click;
            schaarButton.Click += Button_Click;
            papierButton.Click += Button_Click;
        }

        // Bij het kiezen van een waarde moet de timer beginnen te lopen en een waarde worden toegekend
        private void Button_Click(object sender, System.EventArgs e)
        {
            spelTimer.Start();
            lblKeuze.Text = ((Button)sender).Text;
            Label2.Text = "Je hebt gekozen voor:";
        }

        private void spelTimer_Tick(object sender, System.EventArgs e)
        {
            Graphics papier = progressPictureBox.CreateGraphics();
            SolidBrush penneke = new SolidBrush(Color.Blue);
            // telkens het balkje verder opvullen
            papier.Clear(Color.LightGray);
            papier.FillRectangle(penneke, 0, 0, (teller * 29), 15);
            teller = (teller + 1);
            if ((teller == 10))
            {
                spelTimer.Stop();
                gebruikerLabel.Text = lblKeuze.Text;
                Controles(gebruikerLabel.Text);
            }
        }

        private void Controles(string gebruikerwaarde)
        {
            Random rand = new Random();
            int gekozen = rand.Next(1, 4);
            // Random een waarde kiezen
            if ((gekozen == 1))
            {
                computerLabel.Text = "Steen";
            }
            else if ((gekozen == 2))
            {
                computerLabel.Text = "Schaar";
            }
            else
            {
                computerLabel.Text = "Papier";
            }
            // controle wie er wint
            if ((computerLabel.Text == gebruikerLabel.Text))
            {
                winVerliesLabel.Text = "Het is een gelijkspel";
            }
            else if (((computerLabel.Text == "Steen") && (gebruikerLabel.Text == "Schaar")) ||
                     ((computerLabel.Text == "Schaar") && (gebruikerLabel.Text == "Papier")) ||
                     ((computerLabel.Text == "Papier") && (gebruikerLabel.Text == "Steen")))
            {
                winVerliesLabel.Text = "Je hebt verloren";
            }
            else if (((computerLabel.Text == "Schaar") && (gebruikerLabel.Text == "Steen")) ||
                     ((computerLabel.Text == "Papier") && (gebruikerLabel.Text == "Schaar")) ||
                     ((computerLabel.Text == "Steen") && (gebruikerLabel.Text == "Papier")))
            {
                winVerliesLabel.Text = "Je hebt gewonnen";
            }
            steenButton.Enabled = false;
            schaarButton.Enabled = false;
            papierButton.Enabled = false;
            lblKeuze.Text = "";
            Label2.Text = "";
            opnieuwButton.Visible = true;
        }

        private void opnieuwButton_Click(object sender, System.EventArgs e)
        {
            // resetten van het volledige spel
            Graphics papier = progressPictureBox.CreateGraphics();
            papier.Clear(Color.LightGray);
            opnieuwButton.Visible = false;
            winVerliesLabel.Text = "";
            gebruikerLabel.Text = "";
            computerLabel.Text = "";
            lblKeuze.Text = "";
            teller = 0;
            steenButton.Enabled = true;
            schaarButton.Enabled = true;
            papierButton.Enabled = true;
        }

    }
}
