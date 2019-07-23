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

namespace Oef25_3_HoogsteOmzet
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

        private void buttonOmzet_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = null;
            try
            {
                string command = "SELECT Artist FROM Artists ORDER BY sales desc";
                DataTable table = new DataTable();
                adapter = new OleDbDataAdapter(command, connString);
                int count = adapter.Fill(table);

                if (count != 0)
                {
                    MessageBox.Show("Artiest met de meeste sales: " + Convert.ToString(table.Rows[0][0]));
                }
                else
                {
                    MessageBox.Show("Artiest niet gevonden");
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
