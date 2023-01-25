using System;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.Pow(a, 2):f3}");
            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * b):f3}");
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * Math.Pow(r,2):f3}");
            }
            else if (figureType == "triangle") 
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a * h / 2):f3}");
            }
        }
    }
}
