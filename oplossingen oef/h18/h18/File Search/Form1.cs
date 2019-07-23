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

namespace File_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void searchButton_Click(object sender, EventArgs e)
        //{
        //    string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader inputStream = null;

        //    // clear any previous results
        //    result1Label.Text = "";
        //    result2Label.Text = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        string fileToSearch = Path.Combine(sourcepath, fileTextBox.Text);
        //        inputStream = File.OpenText(fileToSearch);
        //        char[] separator = { ',' };
        //        line = inputStream.ReadLine();
        //        while ((line != null) && (!found))
        //        {
        //            words = line.Split(separator);
        //            if (words[0].Trim() == nameTextBox.Text)
        //            {
        //                result1Label.Text = words[1].Trim();
        //                result2Label.Text = words[2].Trim();
        //                found = true;
        //            }
        //            else
        //            {
        //                line = inputStream.ReadLine();
        //            }
        //        }
        //        if (!found)
        //        {
        //            MessageBox.Show(nameTextBox.Text + " not found!");
        //        }
        //        inputStream.Close();
        //    }
        //}

        //private void searchButton_Click(object sender, EventArgs e)
        //{
        //    // search the file with exception handling

        //    string sourcepath = Environment.GetFolderPath(
        //                            Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader inputStream = null;

        //    // clear any previous results
        //    result1Label.Text = "";
        //    result2Label.Text = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string fileToSearch = Path.Combine(sourcepath, fileTextBox.Text);
        //            inputStream = File.OpenText(fileToSearch);
        //            char[] separator = { ',' };
        //            line = inputStream.ReadLine();
        //            while ((line != null) && (!found))
        //            {
        //                words = line.Split(separator);
        //                if (words[0].Trim() == nameTextBox.Text)
        //                {
        //                    result1Label.Text = words[1].Trim();
        //                    result2Label.Text = words[2].Trim();
        //                    found = true;
        //                }
        //                else
        //                {
        //                    line = inputStream.ReadLine();
        //                }
        //            }
        //            if (!found)
        //            {
        //                MessageBox.Show(nameTextBox.Text + " not found!");
        //            }
        //            inputStream.Close();
        //        }
        //        catch (FileNotFoundException ex)
        //        {
        //            MessageBox.Show("Error: File not found: " +
        //                            fileTextBox.Text +
        //                            ". Re-enter name.");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error concerning file: " +
        //                             fileTextBox.Text +
        //                             ". " + ex.Message);
        //        }
        //    }
        //}

        private void searchButton_Click(object sender, EventArgs e)
        {
            // search the file with exception handling

            string sourcepath = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);

            string line = "";
            string[] words = new string[3];
            bool found = false;
            StreamReader inputStream = null;

            // clear any previous results
            result1Label.Text = "";
            result2Label.Text = "";

            if (fileTextBox.Text == "")
            {
                MessageBox.Show("Error: missing file name!");
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("Error: missing student name!");
            }
            else
            {
                try
                {
                    string fileToSearch = Path.Combine(sourcepath, fileTextBox.Text);
                    inputStream = File.OpenText(fileToSearch);
                    //Kris, waarom maak je eigenlijk bij deze oef een array van chars?
                    //een char werkt toch ook? (Array is natuurlijk handig als je ook nog 
                    //andere scheidingstekens wil toelaten; je kan array dan altijd uitbreiden)
                    char separator = ',';
                    //char[] separator = { ',' };
                   
                    line = inputStream.ReadLine();
                    while ((line != null) && (!found))
                    {
                        words = line.Split(separator);
                        if (words[0].Trim() == nameTextBox.Text)
                        {
                            result1Label.Text = words[1].Trim();
                            result2Label.Text = words[2].Trim();
                            found = true;
                        }
                        else
                        {
                            line = inputStream.ReadLine();
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show(nameTextBox.Text + " not found!");
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found: " +
                                    fileTextBox.Text +
                                    ". Re-enter name.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error concerning file: " +
                                     fileTextBox.Text +
                                     ". " + ex.Message);
                }
                finally
                {
                    if (inputStream != null)
                    {
                        inputStream.Close();
                    }
                }
            }
        }
    }
}
