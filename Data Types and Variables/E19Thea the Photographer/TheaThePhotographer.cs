using System;

//19. Thea the Photographer


namespace E19Thea_the_Photographer
{
    public class Thea_the_Photographer
    {
        public static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FF = long.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());

            long totalTimeInSec = N * FT + (long)Math.Ceiling((FF * N / 100.0)) * UT;
            long totalA = totalTimeInSec % 60;
            string Output = Convert.ToString(totalA);
            if (totalA < 10)
            {
                Output = "0" + Output;
            }
            totalTimeInSec = totalTimeInSec / 60;
            totalA = totalTimeInSec % 60;
            Output = Convert.ToString(totalA) + ":" + Output;
            if (totalA < 10)
            {
                Output = "0" + Output;
            }
            totalTimeInSec = totalTimeInSec / 60;
            totalA = totalTimeInSec % 24;
            Output = Convert.ToString(totalA) + ":" + Output;
            if (totalA < 10)
            {
                Output = "0" + Output;
            }
            totalTimeInSec = totalTimeInSec / 24;
                       
            Output = Convert.ToString(totalTimeInSec) + ":" + Output;

            Console.WriteLine(Output);

        }
    }
}
