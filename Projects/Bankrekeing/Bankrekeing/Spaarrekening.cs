using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekeing
{
    class Spaarrekening : Rekening
    {
        private int leeftijd;
        double getal;
        double rente = 0.035;
        Rekening rek;
        private double eindjaar;

        public Spaarrekening(string naam, string rekeningnummer, double saldo, int leeftijd) : base(naam, rekeningnummer, saldo)
        {
            leeftijd = this.leeftijd;

        }

        public string leeftijdtest()
        {
            if (leeftijd < 18)
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
            if ( getSaldo() < 0)
            {
                
                return "Dit is een spaarrekening hier kan je nooit onder 0 gaan";

            }
            else
            {
                return "";
            }
        }
        public string testafhaal()
        {
            if(rek.Afhaal(getal) > 50)
            {
                return "je kan maximum maar 50 euro per keer ophalen";
            }
            else
            {
                return "";
            }
        }
        public double berekenjaar()
        {
            eindjaar = ((getSaldo()*intrest())*12 )-100;
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
