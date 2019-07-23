using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bankrekeing
{
   public abstract class Rekening
    {
        private string naam;
        private string rekeningnummer;
        private double saldo;
        private bool test;

        public Rekening(string naam, string rekeningnummer, double saldo)
        {
            naam = this.naam;
            rekeningnummer = this.rekeningnummer;
            saldo = this.saldo;

        }

        public double getSaldo()
        {
            return saldo;
        }

        public void Stort(double geld)
        {
            saldo = saldo + geld;
        }
        public void Afhaal(double geld)
        {
            saldo = saldo - geld;
        }

        public bool test()
        {
            if (Regex.IsMatch(rekeningnummer, "aaaa-bbbb-ccc")
                {
                return test = true;

                }
        }




    }
}
