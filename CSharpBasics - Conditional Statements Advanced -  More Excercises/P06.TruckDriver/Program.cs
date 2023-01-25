using System;

namespace P06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double salary = 0;

            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                    salary = kilometers * 4 * 0.75;
                else if (season == "Summer")
                    salary = kilometers * 4 * 0.9;
                else if (season == "Winter")
                    salary = kilometers * 4 * 1.05;
            }
            else if (kilometers > 5000 && kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                    salary = kilometers * 4 * 0.95;
                else if (season == "Summer")
                    salary = kilometers * 4 * 1.10;
                else if (season == "Winter")
                    salary = kilometers * 4 * 1.25;
            }
            else if (kilometers > 10000 && kilometers <= 20000)
            {
                salary = kilometers * 4 * 1.45;
            }
            salary *= 0.9;

            Console.WriteLine($"{salary:f2}");
        }
    }
}
