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
using System.Data.OleDb;

namespace Oef25_4_ArtistDataGrid
{
    public partial class Form1 : Form
    {
        private string connString =
            @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;" +
            @"Data Source=..\\..\\..\\MusicSales.sdf";

        
        public Form1()
        {
            InitializeComponent();
        }

        private void artistGridView_Click(System.Object sender, System.EventArgs e)
        {
            OleDbDataAdapter adapter = null;
            try
            {
                string command = "SELECT Artist, Company, Sales FROM Artists ORDER BY sales asc";
                DataTable table = new DataTable();
                adapter = new OleDbDataAdapter(command, connString);
                int count = adapter.Fill(table);

                artistGridView.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if ((adapter != null))
                {
                    adapter.Dispose();
                }
            }
        }
    }
}
