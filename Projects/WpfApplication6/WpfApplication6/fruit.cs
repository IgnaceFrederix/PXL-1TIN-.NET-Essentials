using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6
{
    class fruit
    {
        //instantievariablen
        public string name;
        public int price;
        public double weight;
        

        public void RaisePrice()
        {
            int newPrice = this.price + 10;
            this.price = newPrice;
        }

        public fruit(string name, int price, double weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;

        }
    }
}
