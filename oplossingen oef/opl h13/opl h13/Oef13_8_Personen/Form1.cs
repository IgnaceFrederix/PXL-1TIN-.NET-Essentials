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

namespace Oef13_8_Personen
{
    public partial class Form1 : Form
    {
        private List<Persoon> persoonslijst;

        public Form1()
        {
            InitializeComponent();

            persoonslijst = new List<Persoon>();
            persoonslijst.Add(new Persoon("Hermans", "Kris", "Kerkhof 24, 3560 Houthalen", new DateTime(1975, 5, 15),"1234567",GeslachtEnum.M));
            persoonslijst.Add(new Persoon("Stasik", "Marijke", "Kerkhof 24, 3560 Houthalen", new DateTime(1975, 2, 14), "12345667", GeslachtEnum.V));
            persoonslijst.Add(new Persoon("Hermans", "Ella", "Kerkhof 24, 3560 Houthalen", new DateTime(2003, 12, 25), "1234567", GeslachtEnum.V));
            persoonslijst.Add(new Persoon("Hermans", "Gilles", "Kerkhof 24, 3560 Houthalen", new DateTime(2008, 9, 29), "1234567", GeslachtEnum.M));

            listBox1.Items.AddRange(persoonslijst.ToArray());
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Form f = new DetailsForm(persoonslijst[index]);
            f.Show();
        }
    }
}
