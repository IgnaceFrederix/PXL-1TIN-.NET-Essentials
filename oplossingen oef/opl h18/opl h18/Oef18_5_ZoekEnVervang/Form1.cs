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
using System.IO;

namespace Oef18_5_ZoekEnVervang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(System.Object sender, System.EventArgs e)
        {
            OpenDialog(OpenFileDialog1, sourceTextBox);
        }

        private void saveButton_Click(System.Object sender, System.EventArgs e)
        {
            OpenDialog(SaveFileDialog1, destinationTextBox);
        }

        private void OpenDialog(FileDialog FileDialog, TextBox Textbox)
        {
            FileDialog.Filter = "textfiles *.txt| *.txt|all files *.*|*.*";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox.Text = FileDialog.FileName;
            }
        }

        private void convertButton_Click(System.Object sender, System.EventArgs e)
        {
            string line = null;
            string stringFrom = null;
            string stringTo = null;
            FileStream myInputFile;
            FileStream myOutputFile;
            StreamReader inputStream;
            StreamWriter outputStream;
            try
            {
                myInputFile = new FileStream(sourceTextBox.Text, FileMode.Open, FileAccess.Read);
                inputStream = new StreamReader(myInputFile);
                myOutputFile = new FileStream(destinationTextBox.Text, FileMode.Create, FileAccess.Write);
                outputStream = new StreamWriter(myOutputFile);

                stringFrom = fromTextBox.Text;
                stringTo = toTextBox.Text;

                if (destinationTextBox.Text != "Filename destination" && !string.IsNullOrEmpty(destinationTextBox.Text))
                {
                    while (inputStream.Peek() >= 0)
                    {
                        line = inputStream.ReadLine();
                        outputStream.WriteLine(Change(line, stringFrom, stringTo));
                    }
                    inputStream.Close();
                    outputStream.Close();
                    myInputFile.Close();
                    myOutputFile.Close();
                    MessageBox.Show("Conversion executed, check the result", "CONVERSION DONE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    throw new FileLoadException("help");
                }

            }
            catch (ArgumentException fault)
            {
                MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException fault)
            {
                MessageBox.Show("file not found", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileLoadException fault)
            {
                MessageBox.Show("Give the destination file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (UnauthorizedAccessException fault)
            {
                MessageBox.Show("You chose a directory" + "\r\n" + "Select a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception fault)
            {
                MessageBox.Show("SYSTEM ERROR" + "\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");
            }
        }

        private string Change(string original, string fromText, string toText)
        {
            string leftBit = null;
            string rightBit = null;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length, original.Length - place - fromText.Length);
                    
                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
