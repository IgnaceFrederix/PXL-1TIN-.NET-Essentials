using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;

namespace WpfApplication36
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        void Main()
        {
            Dictionary<string, string> values =
                new Dictionary<string, string>();

            values.Add("cat", "feline");
            values.Add("dog", "canine");
            // Use TryGetValue.
            string test;
            if (values.TryGetValue("cat", out test)) // Returns true.
            {
                Console.WriteLine(test); // This is the value at cat.
            }
            if (values.TryGetValue("bird", out test)) // Returns false.
            {
                Console.WriteLine(false); // Not reached.
            }
        }
    }
}
    
