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

namespace FileStream_Demo
{
    public partial class Form1 : Form
    {
        private string currentFile;
        private string currentFolder;

        public Form1()
        {
            InitializeComponent();

            currentFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = currentFolder;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                currentFolder = Directory.GetParent(currentFile).ToString();
                fileTextBox.Text = currentFile;
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Open,
                                                    FileAccess.Read);
                reader = new StreamReader(fstream);
                mainTextBox.Text = reader.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(fileTextBox.Text + " niet gevonden!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Append,
                                                    FileAccess.Write);
                writer = new StreamWriter(fstream);
                // Append content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            try
            {
                FileStream fstream = new FileStream(currentFile,
                                                    FileMode.Create,
                                                    FileAccess.Write);
                writer = new StreamWriter(fstream);
                // Replace content
                writer.Write(mainTextBox.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }


    }
}
