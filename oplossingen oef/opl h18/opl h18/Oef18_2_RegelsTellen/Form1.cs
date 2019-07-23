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

namespace Oef18_2_RegelsTellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog.Filter = "Text Files (*.txt)|*.TXT|All files (*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text = OpenFileDialog.FileName;
            }
        }

        private void rulesButton_Click(System.Object sender, System.EventArgs e)
        {
            StreamReader inputStreamRead = null;
            FileStream fileStream = null;
            string line = null;
            int lineCounter = 0;
            try
            {
                fileStream = new FileStream(fileTextBox.Text, FileMode.Open, FileAccess.Read);
                inputStreamRead = new StreamReader(fileStream);

                while (inputStreamRead.Peek() >= 0)
                {
                    line = inputStreamRead.ReadLine();
                    lineCounter += 1;
                }
                resultLabel.Text = String.Format("File\r\n{0}\r\ncounts {1} lines", fileTextBox.Text, lineCounter);
            }
            catch (ArgumentException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("file not found", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Zoek in de Help de FileStream constructor. Daar vind je welke Exceptions er 
                //opgegooid kunnen worden ==>UnauthorizedAccessException
            }
            catch (UnauthorizedAccessException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("You chose a directory\r\nSelect a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("SYSTEM ERROR\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");
            }
            finally
            {
                if ((fileStream != null))
                {
                    fileStream.Close();
                }
                if ((fileStream != null))
                {
                    inputStreamRead.Close();
                }
            }
        }
    }
}
