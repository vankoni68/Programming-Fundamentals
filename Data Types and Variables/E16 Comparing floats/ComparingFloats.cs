using System;


namespace E16_Comparing_floats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = Math.Abs(a - b);
            Console.WriteLine(eps < 0.000001? "True" : "False");
           
        }
    }
}
