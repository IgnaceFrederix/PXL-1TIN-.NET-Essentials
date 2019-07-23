using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication17
{
    class Student :Person
    {
       
        //als er geen default const is in de super klas
        public Student(string naam, int age) : base ("naam", 21)
        {

        }
        //als er overide word gebruikt dan word de funtie van de sub klasse gebruikt en niet van de super klasse
        public override string Spreek()
        {
            return "ik ben een student";
        }
        public void doSport()
        {

        }

    }
}
