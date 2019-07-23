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

namespace Oef14_21_22_23_Zoekmethoden
{
    /// <summary>
    /// </summary>
    /// <remarks>
    /// Het opstarten van de applicatie kan wel even duren vermits er 3 
    /// datastructuren opgevuld moeten worden met telkens 1 000 000 elementen. 
    /// </remarks>
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan timeSpan;

        private Dictionary<string, Vak> vakDict = new Dictionary<string, Vak>();
      
        private Vak[] vakArray=new Vak[1000000];
        private List<Vak> vakList;

        public Form1()
        {
            InitializeComponent();
            vakDict = new Dictionary<string, Vak>();
            vakList = new List<Vak>();

            for (int i = 0; i < 1000000; i++)
            {
                vakDict.Add("Vak" + i, new Vak("Vak" + i, "Docent" + i, 5));
                vakArray[i] = new Vak("Vak" + i, "Docent" + i, 5);
                vakList.Add(new Vak("Vak" + i, "Docent" + i, 5));
            }
        }

        // Dictionary
        private void zoekButton_Click(object sender, EventArgs e)
        {
            ZetTijd();

            string key;
            Vak vak;

            key = keyTextBox.Text;
            if (vakDict.ContainsKey(key))
            {
                vak = vakDict[key];
                ToonVak(vak);
            }
            else
            {
                MessageBox.Show("Vak: " + key + " niet gevonden.");
            }

            StopTijd();
        }

        // Array
        private void zoek2Button_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text;

            ZetTijd();

            for (int i = 0; i < vakArray.Length; i++ )
            {
                if (key == vakArray[i].Naam)
                {
                    ToonVak(vakArray[i]);
                    StopTijd();
                    return;   // verlaat de method
                }
            }
            
            MessageBox.Show("Vak: " + key + " niet gevonden.");
            StopTijd();
        }

        // List
        private void zoek3Button_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text;
            bool found = false;

            ZetTijd();

            //1. Zoeken o.b.v. de key (vaknaam)
            foreach (Vak v in vakList)
            {
                if (v.Naam == key)
                {
                    found = true;
                    ToonVak(v);
                    break;  // verlaat de lus voortijdig
                }
            }

            if (!found)
            {
                MessageBox.Show("Vak: " + key + " niet gevonden.");
            }

   
            StopTijd();
        }

        private void ZetTijd()
        {
            startTime = DateTime.Now;
        }

        private void StopTijd()
        {
            stopTime = DateTime.Now;
            timeSpan = stopTime - startTime;
            string line = String.Format("Duur: {0} sec en {1} msec.",timeSpan.Seconds,timeSpan.Milliseconds);
            MessageBox.Show(line);
         }

        private void ToonVak(Vak vak)
        {
            resultTextBox.Clear();

            resultTextBox.AppendText("Vakgegevens voor " + vak.Naam);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("Docent: " + vak.Docent);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText("Uren: " + vak.Uren);
        }
    }
}
