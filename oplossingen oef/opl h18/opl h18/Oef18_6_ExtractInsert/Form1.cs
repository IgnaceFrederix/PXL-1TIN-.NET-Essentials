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

namespace Oef18_6_ExtractInsert
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

        private void OpenDialog(FileDialog FileDialog, TextBox Textbox)
        {
            FileDialog.Filter = "textfiles *.txt| *.txt|all files *.*|*.*";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox.Text = FileDialog.FileName;
            }
        }

        private void extractButton_Click(System.Object sender, System.EventArgs e)
        {
            string line = null;
            FileStream myInputFile = null;
            FileStream myOutputFile = null;
            StreamReader inputStream = null;
            StreamWriter outputStream = null;

            bool copyMode = false;
            // am i writing to a file?

            try
            {
                myInputFile = new FileStream(sourceTextBox.Text, FileMode.Open, FileAccess.Read);
                inputStream = new StreamReader(myInputFile);

                string parent = Directory.GetParent(sourceTextBox.Text).FullName;

                copyMode = false;

                while (inputStream.Peek() >= 0)
                {
                    line = inputStream.ReadLine();
                    if (line.StartsWith("EXTRACTTO"))
                    {
                        copyMode = true;
                        string dest = Path.Combine(parent, line.Substring(line.IndexOf(":") + 1));
                        myOutputFile = new FileStream(dest, FileMode.Create);
                        outputStream = new StreamWriter(myOutputFile);
                    }
                    else if (line.StartsWith("ENDEXTRACT"))
                    {
                        copyMode = false;
                        outputStream.Close();
                        myOutputFile.Close();
                    }
                    else if (copyMode)
                    {
                        outputStream.WriteLine(line);
                    }
                }
                inputStream.Close();
                myInputFile.Close();

                MessageBox.Show("Extraction excecuted, check the result", "EXTRACTION DONE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception fault)
            {
                MessageBox.Show("SYSTEM ERROR" + "\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");

            }
        }

        private void insertButton_Click(System.Object sender, System.EventArgs e)
        {
            string line = null;
            FileStream myInputFile = null;
            FileStream myOutputFile = null;
            StreamReader inputStream = null;
            StreamWriter outputStream = null;

            try
            {
                myInputFile = new FileStream(sourceTextBox.Text, FileMode.Open, FileAccess.Read);
                inputStream = new StreamReader(myInputFile);

                string parent = Directory.GetParent(sourceTextBox.Text).FullName;
                myOutputFile = new FileStream(Path.Combine(parent, "output_of_insert.txt"), FileMode.Create);
                outputStream = new StreamWriter(myOutputFile);

                while (inputStream.Peek() >= 0)
                {
                    line = inputStream.ReadLine();

                    if (line.StartsWith("INSERTFROM"))
                    {
                        string playerFile = Path.Combine(parent, line.Substring(line.IndexOf(":") + 1));
                        InsertFromFile(playerFile, outputStream);
                    }
                    else
                    {
                        outputStream.WriteLine(line);
                    }
                }

                inputStream.Close();
                myInputFile.Close();

                outputStream.Close();
                myOutputFile.Close();

                MessageBox.Show("Extraction excecuted, check the result", "EXTRACTION DONE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception fault)
            {
                MessageBox.Show("SYSTEM ERROR" + "\r\n" + fault.Message + "\r\n" + fault.ToString(), "ERROR");

            }
        }

        private void InsertFromFile(string playerFile, StreamWriter os)
        {
            StreamReader playerStream = new StreamReader(playerFile);

            while (playerStream.Peek() >= 0)
            {
                os.WriteLine(playerStream.ReadLine());
            }

            playerStream.Close();
        }
    }
}
