using System;

namespace P08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.Pow(radius, 2) * Math.PI;
            double circleCircumference = 2 * Math.PI * radius;
            Console.WriteLine(circleArea.ToString("0.00"));
            Console.WriteLine(circleCircumference.ToString("0.00"));
        }
    }
}
