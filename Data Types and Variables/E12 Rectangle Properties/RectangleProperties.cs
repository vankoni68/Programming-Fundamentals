using System;


namespace E12_Rectangle_Properties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double widthRec = double.Parse(Console.ReadLine());
            double heightRec = double.Parse(Console.ReadLine());
            double perimerarRec = (widthRec + heightRec) * 2;
            double areaRec = widthRec * heightRec;
            double diagonalRec = Math.Sqrt(widthRec * widthRec + heightRec * heightRec);
            Console.WriteLine("{0}\n{1}\n{2}", perimerarRec, areaRec, diagonalRec);
        }
    }
}
