using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication17
{
    class Person
    {
        private string name;
        
        private int shoeSize;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age { get; set; }
        //zeflde alleen andere notatie

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public Person(string n, int a, int shoe)
        {
            
        }
        //virtual moet er bij staan als je override wilt gebruiken
        public virtual string Spreek()
        {
            return "mijn naam is" + Name;
        }
    }
}
