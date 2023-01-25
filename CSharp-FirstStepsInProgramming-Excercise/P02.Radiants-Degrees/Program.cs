using System;

namespace P02.Radiants_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radiants: ");
            double radiants = double.Parse(Console.ReadLine());
            double degrees = radiants * (180 / Math.PI);
            Console.WriteLine(degrees);
        }
    }
}
