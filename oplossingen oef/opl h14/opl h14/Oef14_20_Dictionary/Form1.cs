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

namespace Oef14_20_Dictionary
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Vak> lookup = new Dictionary<string, Vak>();

        public Form1()
        {
            InitializeComponent();

            Vak v1 = new Vak("Rapid Application Development", "Kris Hermans", 6);
            Vak v2 = new Vak("Logisch & Algoritmisch Denken", "Veerle Asaert", 7);
            Vak v3 = new Vak("Webdesign", "Rita Lambrechts", 4);

            lookup.Add(v1.Naam, v1);
            lookup.Add(v2.Naam, v2);
            lookup.Add(v3.Naam, v3);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string key;
            Vak vak;

            if (keyTextBox.Text != "")
            {
                key = keyTextBox.Text;
                if (lookup.ContainsKey(key))
                {
                    vak = lookup[key];

                    resultTextBox.Clear();
                    resultTextBox.AppendText("Vakgegevens voor " + key);
                    resultTextBox.AppendText(Environment.NewLine);
                    resultTextBox.AppendText(Environment.NewLine);
                    resultTextBox.AppendText("Docent: " + vak.Docent);
                    resultTextBox.AppendText(Environment.NewLine);
                    resultTextBox.AppendText("Uren: " + vak.Uren);
                }
                else
                {
                    MessageBox.Show("Vak: " + key + " niet gevonden.");
                }
            }
        }

        private void Foo()
        {
            DateTime startTime = DateTime.Now;
            DateTime stopTime;
            TimeSpan timeSpan;

            // hier komt je zoekalgoritme

            stopTime = DateTime.Now;
            timeSpan = stopTime - startTime;
            String line = String.Format("Duur: {0} sec en {1} msec.",
                                        timeSpan.Seconds,
                                        timeSpan.Milliseconds);
            MessageBox.Show(line);
        }
    }
}
