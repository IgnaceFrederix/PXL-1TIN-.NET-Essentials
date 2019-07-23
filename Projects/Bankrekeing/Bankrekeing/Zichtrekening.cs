using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekeing
{
    class Zichtrekening : Rekening
    {

        private int leeftijd;
        Rekening rek;
        double getal;
        double rente = 0;
        private double eindjaar;

        public Zichtrekening(string naam, string rekeningnummer, double saldo, int leeftijd) : base(naam, rekeningnummer, saldo)
        {
            leeftijd = this.leeftijd;

        }
        public string leeftijdtest()
        {
            if (leeftijd < 16)
            {
                return "je bent te jong voor een zichtrekening";
            }
            else
            {
                return "";
            }
        }

        public string ondernul()
        {
            if (leeftijd <= 18 && getSaldo() < -100)
            {
                rente = rente - 0.05;
                return "je bent nog geen 18 jaar dus je kan maar voor maxiumum 100 euro onder 0 dus je kan geen geld meer uitgeven";


            }
            else if (leeftijd > 18 && getSaldo() < -500)
            {
                rente = rente - 0.05;
                return "je bent ouder dan 18 jaar maar je hebt als 500 euro onder 0 dus kan je geen geld meer uitgeven";
            }
            else
            {
                return "";
            }
        }

        public double berekenjaar()
        {
            eindjaar = ((getSaldo() * intrest()) * 12);
            return eindjaar;
        }



        public double intrest()
        {
            getal = rek.getSaldo();
            getal = getal * (1 + rente);
            return getal;
        }


    }
}
