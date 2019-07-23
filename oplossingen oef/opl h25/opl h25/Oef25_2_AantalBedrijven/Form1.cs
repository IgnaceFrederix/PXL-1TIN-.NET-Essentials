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

namespace Oef25_2_AantalBedrijven
{
    public partial class Form1 : Form
    {
        // Deze connectiestring is relatief opgevat tov MusicSales.sdf die zich in de map h25 bevindt.
        private string connString =
            @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;" +
            @"Data Source=..\\..\\..\\MusicSales.sdf";

        public Form1()
        {
            InitializeComponent();
        }

        // methode 1: haalt alle bedrijven op en telt de rijen in de datatable
        private void aantalV1Button_Click(System.Object sender, System.EventArgs e)
        {
            OleDbDataAdapter adapter = null;
            try
            {
                string command = "SELECT * FROM Companies";
                DataTable table = new DataTable();
                adapter = new OleDbDataAdapter(command, connString);
                int count = adapter.Fill(table);

                MessageBox.Show("Aantal bedrijven: " + Convert.ToString(count));

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

        // methode 2: haalt enkel het aantal bedrijven op via de COUNT functie uit SQL
        private void aantalV2Button_Click(System.Object sender, System.EventArgs e)
        {
            OleDbConnection connection = null;

            try
            {
                string sqltext = "SELECT COUNT(*) FROM Companies";
                connection = new OleDbConnection(connString);
                OleDbCommand command = new OleDbCommand(sqltext, connection);
                connection.Open();
                
                int count = (int)command.ExecuteScalar();

                MessageBox.Show("Aantal bedrijven: " + count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if ((connection != null))
                {
                    connection.Close();
                }
            }
        }
    }
}
