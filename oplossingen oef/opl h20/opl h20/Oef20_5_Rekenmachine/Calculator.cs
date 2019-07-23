//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef20_5_Rekenmachine
{
    public class Calculator
    {

        private string display;
        private int getal;
        private int res;
        private string vorigeOperator;
        private string volgendeOperator;
        private bool nieuwGetal;

        public Calculator()
        {
            Reset();
        }

        public void EnterDigit(string digit)
        {
            if (nieuwGetal)
            {
                display = string.Empty;
                nieuwGetal = false;
            }
            display += digit;
        }

        public void EnterOperator(string op)
        {
            getal = Convert.ToInt32(display);
            volgendeOperator = op;
            Count();
        }

        private void Count()
        {
            switch (vorigeOperator)
            {
                case "+":
                    res = res + getal;
                    break;
                case "-":
                    res = res - getal;
                    break;
                default:
                    throw new CalculatorException("Verkeerde operator");
            }

            display = Convert.ToString(res);

            if (volgendeOperator == "=")
            {
                Initialiseer();
            }
            else
            {
                vorigeOperator = volgendeOperator;
            }
            nieuwGetal = true;
        }

        public void Initialiseer()
        {
            res = 0;
            vorigeOperator = "+";
        }

        public void Reset()
        {
            getal = 0;
            res = 0;
            vorigeOperator = "+";
            nieuwGetal = true;

            display = "0";

        }

        public string Display
        {
            get { return display; }
        }
    }

}
