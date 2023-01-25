using System;

namespace P08.PointOnRectangleBorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());


                if (y >= y1 && y <= y2 && x == x1 || // point is on left side
                    y >= y1 && y <= y2 && x == x2 || // point is on right side
                    x >= x1 && x <= x2 && y == y1 || // point is on the top
                    x >= x1 && x <= x2 && y == y2)   // point is at the bottom
                    Console.WriteLine("Border");
                else
                    Console.WriteLine("Inside / Outside");
        }
    }
}
