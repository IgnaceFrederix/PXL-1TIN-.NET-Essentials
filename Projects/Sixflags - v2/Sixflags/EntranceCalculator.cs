using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixflags
{
    public class EntranceCalculator
    {

        private const decimal ADULT_FEE = 15;
        private const decimal MINOR_FEE = 7.5M;
        private List<int> _visitors;

        public EntranceCalculator()
        {
            _visitors = new List<int>();
        }

        public void AddPerson(string name, int age)
        {
            if (name == null || age < 0)
            {
                throw new Exception("must have name, and age can't be negative");
            }
            _visitors.Add(age);
        }

        public decimal CalculateEntrance()
        {
            decimal sum = 0;
            foreach (int age in _visitors)
            {
                if (age > 6)
                {
                    sum += 7.5M;
                } 
                if (age >= 18)
                {
                    sum += 7.5M;
                }
            }
            return sum;
        }
    }
}
