using System;


namespace E18_Different_Integers_Size
{
    public class DifferentIntegersSize1
    {
        public static void Main()
        {            
            try
            {
                string stringN = Console.ReadLine();
                long N = long.Parse(stringN);
                if (N < -9223372036854775808 && N > 9223372036854775807)
                {
                    Console.WriteLine("{0} can't fit in any type", N);
                }
                else
                {
                    Console.WriteLine($"{N} can fit in:");
                    if (N > -129 && N < 128)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (N > -1 && N < 256)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (N > -32769 && N < 32768)
                    {
                        Console.WriteLine("* short");
                    }
                    if (N > -1 && N < 65536)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (N > -2147483649 && N < 2147483648)
                    {
                        Console.WriteLine("* int");
                    }
                    if (N > -1 && N < 4294967296)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (N >= -9223372036854775808 && N <= 9223372036854775807)
                    {
                        Console.WriteLine("* long");
                    }
                }

            }
            catch (Exception N)
            {
                Console.WriteLine("{N} can't fit in any type", N);
                
            }
            

        }
    }
}
