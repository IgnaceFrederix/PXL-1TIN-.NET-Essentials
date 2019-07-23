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

namespace Binding_Navigator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void artistsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artistsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicSalesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicSalesDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this.musicSalesDataSet.Artists);

        }
    }
}
