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

namespace Oef18_9_ToonBestanden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(System.Object sender, System.EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                directoryTextBox.Text = dlg.SelectedPath;
            }
        }

        private void showButton_Click(System.Object sender, System.EventArgs e)
        {
            string line = null;
            int lineCounter = 0;
            FileStream myInputFile = null;
            StreamReader inputStream = null;
            string[] files = null;

            try
            {
                resultsTextBox.Text = string.Empty;
                files = Directory.GetFiles(directoryTextBox.Text);

                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].EndsWith(".txt"))
                    {
                        myInputFile = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                        inputStream = new StreamReader(myInputFile);
                        resultsTextBox.AppendText("File: " + files[i] + "\r\n");
                        lineCounter = 0;
                        while (inputStream.Peek() >= 0 & lineCounter < 10)
                        {
                            line = inputStream.ReadLine();
                            lineCounter += 1;
                            resultsTextBox.AppendText(line + "\r\n");
                        }
                        inputStream.Close();

                        myInputFile.Close();

                    }
                }

            }
            catch (Exception fault)
            {
                MessageBox.Show("SYSTEM ERROR" + "\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");

            }
        }
    }
}
