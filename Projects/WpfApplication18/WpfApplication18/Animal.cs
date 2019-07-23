using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication18
{
    class Animal
    {
        protected string name;
       

        private Animal(string naam)
        {
            name = naam;
        }

 

        public virtual string Sound()
        {
            return "huh?";
        }

        public string Name  { get; set; }

    }

    
}
