using System;

namespace E2_Variable_in_Hexadecimal_Format
{
    class E2_Variable_in_Hexadecimal_Format
    {
        static void Main(string[] args)
        {
            string verString = Console.ReadLine();
            bool verBool = Convert.ToBoolean(verString);
            Console.WriteLine(verBool ? "Yes" : "No");

        }
    }
}
