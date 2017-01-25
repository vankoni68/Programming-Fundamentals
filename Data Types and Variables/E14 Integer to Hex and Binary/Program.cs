using System;

namespace E14_Integer_to_Hex_and_Binary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int decNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Convert.ToString(decNum, 16).ToUpper());
            Console.WriteLine(Convert.ToString(decNum, 2));
        }
    }
}
