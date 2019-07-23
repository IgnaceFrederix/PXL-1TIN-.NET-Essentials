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
using System.Globalization;

namespace ConvertToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            int num = 44;
            double d = 1.234;
            s1 = Convert.ToString(num);
            s2 = Convert.ToString(d);

            MessageBox.Show(s1);
            MessageBox.Show(s2);

            // Dit werkt niet op een Nederlands/Belgisch systeem
            //s1 = "12.3";
            //s2 = "567";
            //d = Convert.ToDouble(s1);
            //num = Convert.ToInt32(s2);
            //MessageBox.Show("" + d + " " + num);

            // We geven aan dat het een Amerikaanse getalvoorstelling betreft
            // moet wel bovenaan using System.Globalization
            s1 = "12.3";
            CultureInfo cult = new CultureInfo("en-US");
            d = Convert.ToDouble(s1, cult.NumberFormat);
            MessageBox.Show("" + d);

            //Testvraag 4.8
            int m, n;
            string s;
            string v = "3";
            m = Convert.ToInt32(v + v + "4");
            n = Convert.ToInt32(v + v) + 4;
            s = Convert.ToString(Convert.ToInt32(v)
                + Convert.ToInt32(v)) + "4";
            MessageBox.Show("m = " + m + "\n" +
                            "n = " + n + "\n" +
                            "s = " + s);
        }
    }
}
