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

namespace Oef16_9_zoeken_vervangen
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Hoofdstuk 16, oefening 9: zoeken en vervangen in grote strings
        /// </summary>
        private string searchString; 
        private string replaceString; 
        private string textString;
 
        public Form1()
        {
            InitializeComponent();
            algorithmComboBox.SelectedIndex = 0;
        }

        private bool CheckConditions()
        {

            string msg = String.Empty;
            if (searchTextBox.Text == "")
            {
                msg = msg + " Search veld ";
            }
            else
            {
                searchString = searchTextBox.Text;
            }

            if (replaceTextBox.Text == "")
            {
                msg = msg + " Replace veld ";
            }
            else
            {
                replaceString = replaceTextBox.Text;
            }

            if (stringTextBox.Text == "")
            {
                msg = msg + " Tekst veld";
            }
            else
            {
                textString = stringTextBox.Text;
            }

            if (msg != "")
            {
                msg = "Volgende velden zijn nog niet ingevuld: " + msg;
                MessageBox.Show(msg, "Velden invullen",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DoReplace1()
        {
            string leftBit, rightBit;
            int startSearch = 0;
            int place = textString.IndexOf(searchString);

            if (searchString.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = textString.Substring(0, place);
                    rightBit = textString.Substring(place + searchString.Length,
                                            textString.Length - place - searchString.Length);
                    textString = leftBit + replaceString + rightBit;
                    startSearch = leftBit.Length + replaceString.Length;
                    place = textString.IndexOf(searchString);
                }
            }
 
            stringTextBox.Clear();
            stringTextBox.Text = textString;
        }

        private void DoReplace2()
        {
            int startIndex = 0;
            int foundIndex = textString.IndexOf(searchString, startIndex);
            StringBuilder replacedText = new StringBuilder();

            while (foundIndex != -1)
            {
                replacedText.Append(textString.Substring(startIndex, foundIndex - startIndex));
                replacedText.Append(replaceString);
                startIndex = foundIndex + searchString.Length;
                if (startIndex >= textString.Length)
                {
                    foundIndex = -1;
                }
                else
                {
                    foundIndex = textString.IndexOf(searchString, startIndex);
                }
            }

            //kopieer het laatste stuk naar replacedText
            replacedText.Append(textString.Substring(startIndex));
            stringTextBox.Clear();
            stringTextBox.Text = replacedText.ToString();
        }

        private void DoReplace3()
        {
            stringTextBox.Text = textString.Replace(searchString, replaceString);
        }


        private void executeButton_Click(object sender, EventArgs e)
        {
            long startTime, stopTime;
            if (CheckConditions())
            {
                startTime = DateTime.Now.Ticks;
                switch (algorithmComboBox.SelectedIndex)
                {
                    case 0: DoReplace1();
                            break;
                    case 1: DoReplace2();
                            break;
                    case 2: DoReplace3();
                            break;
                }
                stopTime = DateTime.Now.Ticks;
                statusBar1.Text = "Uitgevoerd in " +
                                  string.Format("{0:D} msec", (stopTime - startTime) / 10000);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stringTextBox.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string line = "aaa aaa bbb bbb bb aa aa bb bb cc";
            int aLijnen = 1000;
            int i = 0;

            stringTextBox.Clear();

            for (i = 0; i < aLijnen; i++)
            {
                stringTextBox.AppendText(line);
            }
        }
    }
}
