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

namespace Database_Example
{
    public partial class Form1 : Form
    {
        private string connectionString =
         @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=|DataDirectory|\MusicSales.sdf";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                
                // set up an SQL query
                string command = "SELECT * FROM Artists WHERE " +
                                 "Artist = '" + artistTextBox.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command, connectionString);
                sqlLabel.Text = command;

                // do the query
                table.Clear();
                int recordCount = adapter.Fill(table);

                // display results
                if (recordCount != 0)
                {
                    companyTextBox.Text = Convert.ToString(table.Rows[0][1]);
                    salesTextBox.Text = Convert.ToString(table.Rows[0][2]);
                }
                else
                {
                    MessageBox.Show("Artist not found!");
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            DataTable table = new DataTable();
            OleDbCommand updateCommand = new OleDbCommand();
            try
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                // set up an SQL update
                string command = "UPDATE Artists SET Company = '"+
                                 companyTextBox.Text + "', Sales = '" +
                                 salesTextBox.Text + "' WHERE Artist = '" +
                                 artistTextBox.Text + "'";
                sqlLabel.Text = command;
                
                // put the command in the adapter
                updateCommand.CommandText = command;
                updateCommand.Connection = connection;
                adapter.UpdateCommand = updateCommand;

                // do the update
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand insertCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            try
            {
                connection.Open();
                string command = "INSERT INTO Artists" +
                                 "(Artist, Company, Sales) " +
                                 "VALUES('" + artistTextBox.Text + "', '" +
                                 companyTextBox.Text + "', " +
                                 salesTextBox.Text + ")";
                sqlLabel.Text = command;

                // put the command in the adapter
                insertCommand.Connection = connection;
                insertCommand.CommandText = command;
                adapter.InsertCommand = insertCommand;

                // do the insert
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand deleteCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            try
            {
                connection.Open();
                string command = "DELETE FROM Artists WHERE Artist = '" +
                                 artistTextBox.Text + "'";
                sqlLabel.Text = command;

                // put the command in the adapter
                deleteCommand.Connection = connection;
                deleteCommand.CommandText = command;
                adapter.DeleteCommand = deleteCommand;

                // do the insert
                int rowsAffecting = adapter.DeleteCommand.ExecuteNonQuery();
                if (rowsAffecting == 0)
                {
                    MessageBox.Show("Deletion not executed.");
                }
                else
                {
                    MessageBox.Show("Artist deleted.");
                }
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
