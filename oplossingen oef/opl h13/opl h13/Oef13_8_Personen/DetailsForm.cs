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
    public partial class DetailsForm : Form
    {
        private Persoon persoon;

        public DetailsForm(Persoon p)
        {
            InitializeComponent();

            persoon = p;
            naamTextBox.Text = persoon.Naam;
            voornaamTextBox.Text = persoon.Voornaam;
            adresTextBox.Text = persoon.Adres;
            manRadioButton.Checked = (persoon.Geslacht == GeslachtEnum.M);
            vrouwRadioButton.Checked = (persoon.Geslacht == GeslachtEnum.V);
            telTextBox.Text = persoon.Telefoon;
            geboorteTextBox.Text = String.Format("{0:d}", persoon.GeboorteDatum);
        }
    }
}
