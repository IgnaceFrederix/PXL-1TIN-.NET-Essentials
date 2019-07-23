using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenZelfGemaaktOplossing
{
    public class Klas
    {
        public Klas(string klasnaam, string kortnaam)
        {
            this.klasnaam = klasnaam;
            this.kortnaam = kortnaam;
            this.studenten = new List<Student>();
            this.hoeveel = hoeveel;
        }


        public String klasnaam { get; set; }
        public String kortnaam { get; set; }
        public List<Student> studenten { get; set;}
        public int hoeveel { get; set; }
        public override string ToString()
        {
            return klasnaam + " - " + hoeveel + " studenten";
        }
    }
}
