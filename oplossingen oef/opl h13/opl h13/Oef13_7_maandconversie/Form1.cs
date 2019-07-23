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

namespace Oef13_7_maandconversie
{
    /// <summary>
    /// Hoofdstuk 13, oefening 7: maandconversie, nu met een generische lijst
    /// </summary>
    public partial class Form1 : Form
    {
        private IList<string> months;
        
        public Form1()
        {
            InitializeComponent();
            months = new List<string>(); 
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");   
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int monthNumber;
            string monthname;

            monthNumber = Convert.ToInt32(textBox1.Text);
            monthname = months[monthNumber - 1];
            textBox2.Text = monthname;
        }
    }
}
