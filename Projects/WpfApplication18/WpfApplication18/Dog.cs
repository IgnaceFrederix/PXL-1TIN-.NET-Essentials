using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication18
{
    class Dog : Animal
    {

        public Dog(string naam) : base(naam)
        {
           this.name = naam;
        }

        public override string Sound()
        {
            return base.Sound();
        }


    }
}
