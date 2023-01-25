using System;

namespace P02.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a * h) / 2;
            Console.WriteLine(area.ToString("0.00"));
        }
    }
}
