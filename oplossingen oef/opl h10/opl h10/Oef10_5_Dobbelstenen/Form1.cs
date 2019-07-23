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

namespace Oef10_5_Dobbelstenen
{
    /// <summary>
    /// Hoofdstuk 10, oefening 5: Dobbelsteen
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void werpButton_Click(object sender, EventArgs e)
        {
            Dobbelsteen dobbelsteen1, dobbelsteen2;
            int worp1, worp2;
            
            dobbelsteen1=new Dobbelsteen();
            dobbelsteen2=new Dobbelsteen();
            pictureBox1.CreateGraphics().Clear(this.BackColor);
            pictureBox2.CreateGraphics().Clear(this.BackColor);

            worp1=dobbelsteen1.Werp();
            dobbelsteen1.ToonDobbelsteen(pictureBox1,worp1);
            worp2=dobbelsteen2.Werp();
            dobbelsteen2.ToonDobbelsteen(pictureBox2,worp2);
        }
    }
}
