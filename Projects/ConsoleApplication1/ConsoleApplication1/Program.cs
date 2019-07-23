using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            string name = Console.ReadLine();
            Console.WriteLine("hey"+ name);
            string wait = Console.ReadLine();
            string fileName = "File.txt";

            string searchTerm = args[1];
            StreamReader inputStream = File.OpenText(fileName);
            string line = inputStream.ReadLine();
            while(line!= null)
            {
                if (line.Contains(searchTerm))
                    Console.WriteLine(line);
                line = inputStream.ReadLine();
            } 
          
        }
    }
}
