using System;

namespace P07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double houseHeight = double.Parse(Console.ReadLine());
            double houseLenght = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());
            double Window = 1.5 * 1.5;
            double Door = 1.2 * 2;
            double houseBigSides = (houseHeight * houseLenght - Window) * 2;
            double houseSmallSides = houseHeight * houseHeight * 2 - Door;
            double houseArea = houseBigSides + houseSmallSides;
            double houseLiters = houseArea / 3.4;
            double roofRectangles = houseHeight * houseLenght * 2;
            double roofTriangles = 0.5 * houseHeight * roofHeight * 2;
            double roofArea = roofRectangles + roofTriangles;
            double roofLiters = roofArea / 4.3;
            Console.WriteLine(houseLiters.ToString("0.00"));
            Console.WriteLine(roofLiters.ToString("0.00"));
        }
    }
}
