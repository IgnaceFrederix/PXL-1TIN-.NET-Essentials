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

namespace Oef23_5_IMyList
{
    public partial class Form1 : Form
    {
        private StringList myStrings;

        public Form1()
        {
	        InitializeComponent();

	        myStrings = new StringList();
	        stringsListBox.DataSource = myStrings.Contents;
        }

        private void addButton_Click(System.Object sender, System.EventArgs e)
        {
	        myStrings.Add(txtString.Text);
	        stringsListBox.DataSource = null;
	        stringsListBox.DataSource = myStrings.Contents;
        }

        private void searchButton_Click(System.Object sender, System.EventArgs e)
        {
	        int pos = myStrings.IndexOf(txtString.Text);
	        MessageBox.Show("positie: " + Convert.ToString(pos));
        }


        private void deleteButton_Click(System.Object sender, System.EventArgs e)
        {
	        myStrings.Remove(txtString.Text);
	        stringsListBox.DataSource = null;
	        stringsListBox.DataSource = myStrings.Contents;
        }
    }
}
