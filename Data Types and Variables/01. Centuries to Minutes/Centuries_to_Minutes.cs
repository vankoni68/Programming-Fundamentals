﻿using System;


namespace Lab01.Centuries_to_Minutes
{
    public class Centuries_to_Minutes
    {
        public static void Main()
        {
            short centure = short.Parse(Console.ReadLine());
            var years = centure * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong secondes = (ulong)minutes * 60;
            ulong milisecundes = secondes * 1000;
            ulong microsecundes = milisecundes * 1000;
            decimal nanosecundes = (decimal)microsecundes * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centure, years, days, hours, minutes, secondes, milisecundes, microsecundes, nanosecundes);
        
        }
    }
}
