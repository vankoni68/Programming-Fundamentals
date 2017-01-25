using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cources = (int)(persons/capacity);
            if (persons % capacity != 0)
            {
                cources++;
            }
            Console.WriteLine(cources);
            printHi();
        }

        private static void printHi()
        {
            throw new NotImplementedException();
        }
    }
}
