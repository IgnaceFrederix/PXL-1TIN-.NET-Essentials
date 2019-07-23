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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        private string connectionString = 
          @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=|DataDirectory|\MusicSales.sdf";
        private DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void highSalesButton_Click(object sender, EventArgs e)
        {
            string command;

            try
            {
                command = "SELECT Artist, Company, Sales FROM Artists WHERE Sales >= " +
                          salesAboveTextBox.Text;
                sqlLabel.Text = command;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionString);

                dataTable.Clear();
                adapter.Fill(dataTable);
                artistsDataGridView.DataSource = dataTable;
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
    }
}
