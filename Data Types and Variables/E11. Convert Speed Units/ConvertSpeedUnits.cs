using System;


namespace E11.Convert_Speed_Units
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distanceM = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int secundes = int.Parse(Console.ReadLine());
            float hoursAll = (float)(hours + minutes / 60.0 + secundes / 3600.0);
            float secundesAll = hoursAll * 3600;
            float speedMeterspS = (float)distanceM / secundesAll;
            float speedKmpH = ((float)distanceM / 1000) / hoursAll;
            float speedMilespH = ((float)distanceM / 1609) / hoursAll;
            Console.WriteLine("{0:0.#######}\n{1:0.#######}\n{2:0.#######}", speedMeterspS, speedKmpH, speedMilespH);
        }
    }
}
