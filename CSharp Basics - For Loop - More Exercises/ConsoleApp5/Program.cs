using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                char sector = Convert.ToChar(Console.ReadLine());
                switch (sector)
                {
                    case 'A':
                        sectorA++;
                        break;
                    case 'B':
                        sectorB++;
                        break;
                    case 'V':
                        sectorV++;
                        break;
                    case 'G':
                        sectorG++;
                        break;
                }
            }
            double percentageA = sectorA / fansCount * 100;
            double percentageB = sectorB / fansCount * 100;
            double percentageV = sectorV / fansCount * 100;
            double percentageG = sectorG / fansCount * 100;
            double percentageAllFans = fansCount / stadiumCapacity * 100;
            Console.WriteLine($"{percentageA:f2}%");
            Console.WriteLine($"{percentageB:f2}%");
            Console.WriteLine($"{percentageV:f2}%");
            Console.WriteLine($"{percentageG:f2}%");
            Console.WriteLine($"{percentageAllFans:f2}%");
        }
    }
}
