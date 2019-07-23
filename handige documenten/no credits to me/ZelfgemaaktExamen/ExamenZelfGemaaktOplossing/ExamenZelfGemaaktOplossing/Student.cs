using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ExamenZelfGemaaktOplossing
{
    public class Student
    {
        public Student(char klas,string naam, string passwoord, string datum)
        {
            this.naam = naam;
            this.passwoord = passwoord;
            this.datum = datum;
            this.klas = klas;
            this.punten = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                punten.Add(0);
            }


        }

        public List<int> punten { get; set; }
        public string naam { get; set; }
        public string passwoord { get; set; }
        public string datum { get; set; }
        public char klas { get; set; }
    }
}
