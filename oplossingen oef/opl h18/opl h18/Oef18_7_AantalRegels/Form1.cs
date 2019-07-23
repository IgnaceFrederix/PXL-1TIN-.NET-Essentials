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

namespace Oef18_7_AantalRegels
{
    public partial class Form1 : Form
    {
        private string myFolder;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(System.Object sender, System.EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                myFolder = FolderBrowserDialog.SelectedPath;
                fileTextBox.Text = myFolder;
            }
        }

        private void rulesButton_Click(System.Object sender, System.EventArgs e)
        {
            string[] files = Directory.GetFiles(myFolder);
            int count = 0;
            int totalCount = 0;
            
            for (count = 0; count < files.Length; count++)
            {
                totalCount = totalCount + RuleCounter(files[count]);
            }
            resultLabel.Text = ("Directory " + "\r\n" + myFolder + "\r\n" + "counts " + Convert.ToString(totalCount) + " lines in " + Convert.ToString(files.Length) + " files.");
        }

        private int RuleCounter(string fileName)
        {
            StreamReader inputStreamRead = null;
            FileStream fileStream = null;
            string line = null;
            int lineCounter = 0;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                inputStreamRead = new StreamReader(fileStream);

                while (inputStreamRead.Peek() >= 0)
                {
                    line = inputStreamRead.ReadLine();
                    lineCounter += 1;
                }
                inputStreamRead.Close();
                return lineCounter;

            }
            catch (ArgumentException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException fault)
            {
                MessageBox.Show("file not found", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (UnauthorizedAccessException fault)
            {
                MessageBox.Show("You chose a directory" + "\r\n" + "Select a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception fault)
            {
                MessageBox.Show("SYSTEM ERROR" + "\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");
            }
            return lineCounter;
        }
    }
}
