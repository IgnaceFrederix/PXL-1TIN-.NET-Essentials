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

namespace Oef18_3_ZoekString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(System.Object sender, System.EventArgs e)
        {
            openFileDialog.Filter = "Text Files (*.txt)|*.TXT|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void searchButton_Click(System.Object sender, System.EventArgs e)
        {
            StreamReader inputStreamRead;
            FileStream inputFileStream;
            string line = null;
            string result = null;
            int lineCounter = 1;
            int appearence = 0;
            int rulePos = 0;

            try
            {
                inputFileStream = new FileStream(fileTextBox.Text, FileMode.Open, FileAccess.Read);
                inputStreamRead = new StreamReader(inputFileStream);


                resultTextBox.Text = "";

                while (inputStreamRead.Peek() >= 0)
                {
                    line = inputStreamRead.ReadLine();
                    rulePos = line.IndexOf(stringTextBox.Text);
                    if ((rulePos > -1))
                    {
                        result = fileTextBox.Text.Substring(fileTextBox.Text.LastIndexOf("\\") + 1, fileTextBox.Text.Length - fileTextBox.Text.LastIndexOf("\\") - 1);
                        result = result + ": " + "line:" + Convert.ToString(lineCounter) + " - " + line + Environment.NewLine;
                        resultTextBox.AppendText(result);
                        appearence += 1;
                    }
                    lineCounter += 1;
                }
                resultTextBox.AppendText(Environment.NewLine + "String " + stringTextBox.Text + " found in " + Convert.ToString(appearence) + " lines of " + Convert.ToString(lineCounter - 1) + " lines");
                inputStreamRead.Close();
                inputFileStream.Close();

            }
            catch (ArgumentException fault)
            {
                resultTextBox.Text = "FAULT";
                MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException fault)
            {
                resultTextBox.Text = "FAULT";
                MessageBox.Show("file not found", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (UnauthorizedAccessException fault)
            {
                resultTextBox.Text = "FAULT";
                MessageBox.Show("You chose a directory" + Environment.NewLine + "Select a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception fault)
            {
                resultTextBox.Text = "FAULT";
                MessageBox.Show("SYSTEM ERROR" + Environment.NewLine + fault.Message + Environment.NewLine + fault.ToString(), "ERROR");

            }
        }
    }
}
