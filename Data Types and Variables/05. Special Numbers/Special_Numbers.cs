using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = false;
                int l = i;
                int k;
                int sum = 0;
                do
                {
                   k = l % 10;
                   l = l / 10;
                    sum += k;
                } while (l != 0);

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine("{0} -> {1}", i, isSpecial);               
            }
        }
    }
}
