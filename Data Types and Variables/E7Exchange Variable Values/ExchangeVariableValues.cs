using System;


namespace E7Exchange_Variable_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);
            b = a - b;
            a = a - b;
            b = b + a;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
