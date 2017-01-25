using System;


namespace _02.Circle_Area__Precision_12_
{
    public class CircleAreaPrecision12
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", r * r * Math.PI);
        }
    }
}
