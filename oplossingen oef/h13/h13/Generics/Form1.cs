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

namespace Generics
{
    public partial class Form1 : Form
    {
        private IList<string> list;
        
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            list.Add("bread");
            list.Add("milk");
            list.Add("coffee");
           
        }

        //private void displayButton_Click(object sender, EventArgs e)
        //{
        //    for (int index = 0; index < list.Count; index++)
        //    {
        //        shoppingListBox.Items.Add(list[index]);
        //    }
        //}

        private void displayButton_Click(object sender, EventArgs e)
        {
            foreach (string s in list)
            {
                shoppingListBox.Items.Add(s);
            }
        }

        private void bindButton_Click(object sender, EventArgs e)
        {
            shoppingListBox.DataSource = list;
        }

    }
}
