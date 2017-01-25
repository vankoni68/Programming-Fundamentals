using System;

namespace E17_Print_Part_of_the_ASCII_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());
            for (int i = firstIndex; i < lastIndex; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine((char)lastIndex);
        }
    }
}
