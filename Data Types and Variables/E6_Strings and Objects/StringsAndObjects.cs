using System;


namespace E6_Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object stringPlus = string1 + " " + string2;
            string string3 = (string)stringPlus;
            Console.WriteLine(string3);

        }
    }
}
