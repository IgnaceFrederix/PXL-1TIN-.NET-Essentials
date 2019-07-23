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

namespace Oef18_4_VergelijkBestanden
{
    public partial class Form1 : Form
    {
        private OpenFileDialog dialog;

        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            dialog = new OpenFileDialog();
        }

        private void TextBoxFile1_TextChanged(System.Object sender, System.EventArgs e)
        {
            InitializeLabel();
        }

        private void TextBoxFile2_TextChanged(System.Object sender, System.EventArgs e)
        {
            InitializeLabel();
        }

        private void InitializeLabel()
        {
            resultLabel.ForeColor = Color.Black;
            resultLabel.Text = "Equal / Differ";
        }

        private void browse1Button_Click(System.Object sender, System.EventArgs e)
        {
            OpenDialog(file1TextBox);
        }

        private void browse2Button_Click(System.Object sender, System.EventArgs e)
        {
            OpenDialog(file2TextBox);
        }

        private void OpenDialog(TextBox TextBoxFile)
        {
            dialog.Filter = "Text Files (*.txt)|*.TXT|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxFile.Text = dialog.FileName;
            }
        }

        private void compareButton_Click(System.Object sender, System.EventArgs e)
        {
            bool compareResult = true;
            string line1 = null;
            string line2 = null;
            StreamReader inputStream1;
            StreamReader inputStream2;

            try
            {
                inputStream1 = File.OpenText(file1TextBox.Text);
                try
                {
                    inputStream2 = File.OpenText(file2TextBox.Text);

                    while (inputStream1.Peek() >= 0)
                    {
                        line1 = inputStream1.ReadLine();
                        if (inputStream2.Peek() >= 0)
                        {
                            line2 = inputStream2.ReadLine();
                        }
                        else
                        {
                            line2 = null;
                        }

                        if (line1 != line2)
                        {
                            compareResult = false;
                            //          Throw ("Mis") 
                        }
                    }

                    if (compareResult == true)
                    {
                        resultLabel.ForeColor = Color.Blue;
                        resultLabel.Text = "EQUAL";
                    }
                    else
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "DIFFER";
                    }

                }
                catch (ArgumentException fault)
                {
                    resultLabel.Text = "FAULT";
                    MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FileNotFoundException fault)
                {
                    resultLabel.Text = "FAULT";
                    MessageBox.Show("File 2: " + file2TextBox.Text + " not found.", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException fault)
                {
                    resultLabel.Text = "FAULT";
                    MessageBox.Show("You chose a directory" + Environment.NewLine + "Select a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception fault)
                {
                    resultLabel.Text = "FAULT";
                    MessageBox.Show("SYSTEM ERROR" + Environment.NewLine + fault.Message + Environment.NewLine + fault.ToString(), "ERROR");
                }

            }
            catch (ArgumentException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("empty string", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("File 1: " + file1TextBox.Text + " not found.", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("You chose a directory" + Environment.NewLine + "Select a file", "FILE ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fault)
            {
                resultLabel.Text = "FAULT";
                MessageBox.Show("SYSTEM ERROR" + Environment.NewLine + fault.Message + Environment.NewLine + fault.ToString(), "ERROR");
            }
        }

    }
}
