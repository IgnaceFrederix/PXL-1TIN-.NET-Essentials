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

namespace Oef8_11_Kinderliedje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zingButton_Click(object sender, EventArgs e)
        {
            int i;
            string[] getallen = {"Zeven", "Zes" , "Vijf", "Vier", "Drie", "Twee", "Eén"};
            for (i = 0; i <= 6; i++)
            {
                if ((getallen[i] == "Eén"))
                {
                    rijmTextBox.AppendText(getallen[i] + " klein visje, dat zwom naar de zee\r\n");
                }
                else
                {
                    rijmTextBox.AppendText(getallen[i] + " kleine visjes, die zwommen naar de zee\r\n");
                }
                rijmTextBox.AppendText("Nee, zei de moeder, ik ga niet mee\r\n");
                rijmTextBox.AppendText("Ik blijf liever in de vieze ouwe sloot\r\n");
                rijmTextBox.AppendText("Want in de zee daar zwemt de haai en die bijt je dan... dood.\r\n");
                rijmTextBox.AppendText("\r\n");
            }
        }
    }
}
