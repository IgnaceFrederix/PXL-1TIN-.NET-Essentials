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

namespace Oef16_7_PlusMinGeheugen
{
    public partial class Form1 : Form
    {
        int[] geheugen = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            char[] spatie = new char[] { ' ' };
            string[] tekens = invoerTextBox.Text.Split(spatie);
            // splits alle termen op spaties

            if (tekens[0] == "setm")
            {
                ZetInGeheugen(Convert.ToInt32(tekens[1]), Convert.ToInt32(tekens[2]));
                resultLabel.Text = String.Format("geheugen[{0}] <- {1}", tekens[1], tekens[2]);
            }
            else if (tekens[0].StartsWith("m") && tekens[1] == "=")
            {
                int loc = Convert.ToInt32(tekens[0].Substring(1));
                geheugen[loc] = Eval(tekens, 2);
            }
            else if (tekens[0] == "display")
            {
                resultLabel.Text = Convert.ToString(geheugen[Convert.ToInt32(tekens[1].Substring(1))]);
            }
            else
            {
                resultLabel.Text = Convert.ToString(Eval(tekens, 0));
            }

        }

        private void ZetInGeheugen(int loc, int val)
        {
            geheugen[loc] = val;
        }

        /// <summary>
        /// evalueer de expressie in t vanaf de positie start, we veronderstellen dat vanaf start dit is van de vorm
        /// 12 + 345 - 44 - 23 - 57
        /// ook dit kan:
        /// 12 + m0 - m3
        /// </summary>
        /// <param name="t"></param>
        /// <param name="start">startindex</param>
        /// <returns></returns>
        /// <remarks></remarks>
        private int Eval(string[] t, int start)
        {
            int s = GeefGetal(t[start]);
            int p = start;

            while (p < t.Length - 1)
            {
                string oper = t[p + 1];
                int g = GeefGetal(t[p + 2]);

                if (oper == "+")
                {
                    s = s + g;
                }
                else
                {
                    s = s - g;
                }

                p = p + 2;
            }


            return s;
        }

        private int GeefGetal(string t)
        {
            if (t.StartsWith("m"))
            {
                return geheugen[Convert.ToInt32(t.Substring(1))];
            }
            return Convert.ToInt32(t);
        }
    }
}
