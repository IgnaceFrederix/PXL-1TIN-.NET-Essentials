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

namespace Oef18_8_ZoekStringInDirectory
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


        private void searchButton_Click(System.Object sender, System.EventArgs e)
        {
            resultTextBox.Clear();
            string[] txtfiles = Directory.GetFiles(directoryTextBox.Text, "*.txt");
            foreach (string txtfile in txtfiles)
            {
                SearchFile(txtfile, searchTextBox.Text);
            }
        }

        private void SearchFile(string f, string toSearch)
        {
            StreamReader reader = null;
            try
            {
                reader = File.OpenText(f);
                string line = reader.ReadLine();
                int linenumber = 1;
                int column = -1;
                while ((line != null))
                {
                    column = line.IndexOf(toSearch);
                    if (column != -1)
                    {
                        resultTextBox.AppendText(f);
                        resultTextBox.AppendText(" ");
                        resultTextBox.AppendText(Convert.ToString(linenumber));
                        resultTextBox.AppendText(":");
                        resultTextBox.AppendText(Convert.ToString(column));
                        resultTextBox.AppendText(Environment.NewLine);
                    }
                    line = reader.ReadLine();
                    linenumber += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Close();
                }
            }
        }
    }
}
