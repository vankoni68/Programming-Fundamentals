using System;


namespace E09_Reversed_chars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            string allLetter = $"{thirdLetter}{secondLetter}{firstLetter}";

            Console.WriteLine(allLetter);
        }
    }
}
