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

namespace Oef25_1_LokatieBedrijf
{
    public partial class Form1 : Form
    {
        // Deze connectiestring is relatief opgevat tov MusicSales.sdf die zich in de map H25 bevindt.
        private string connString = 
            @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;"+
            @"Data Source=..\\..\\..\\MusicSales.sdf";

        public Form1()
        {
            InitializeComponent();
        }

        private void zoekButton_Click(System.Object sender, System.EventArgs e)
        {
            OleDbDataAdapter adapter = null;
            try
            {
                string command = "SELECT Location FROM Companies WHERE Company = '" + naamTextBox.Text + "'";
                DataTable table = new DataTable();
                adapter = new OleDbDataAdapter(command, connString);
                int count = adapter.Fill(table);

                if (count != 0)
                {
                    MessageBox.Show("Lokatie: " + Convert.ToString(table.Rows[0][0]));
                }
                else
                {
                    MessageBox.Show("Bedrijf niet gevonden");
                }

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
