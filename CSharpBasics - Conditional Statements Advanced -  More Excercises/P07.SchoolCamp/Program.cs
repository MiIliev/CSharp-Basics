using System;

namespace P07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int participants = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = null;

            switch (season)
            {
                case "Winter":
                    if (groupType == "boys" || groupType == "girls")
                        price = 9.60;
                    else if (groupType == "mixed")
                        price = 10;
                    break;
                case "Spring":
                    if (groupType == "boys" || groupType == "girls")
                        price = 7.20;
                    else if (groupType == "mixed")
                        price = 9.50;
                    break;
                case "Summer":
                    if (groupType == "boys" || groupType == "girls")
                        price = 15;
                    else if (groupType == "mixed")
                        price = 20;
                    break;
            }

            if (participants >= 50)
                price *= 0.5;
            else if (participants >= 20 && participants < 50)
                price *= 0.85;
            else if (participants >= 10 && participants < 20)
                price *= 0.95;

            switch (groupType)
            {
                case "girls":
                    if (season == "Winter")
                        sport = "Gymnastics";
                    else if (season == "Spring")
                        sport = "Athletics";
                    else if (season == "Summer")
                        sport = "Volleyball";
                    break;
                case "boys":
                    if (season == "Winter")
                        sport = "Judo";
                    else if (season == "Spring")
                        sport = "Tennis";
                    else if (season == "Summer")
                        sport = "Football";
                    break;
                case "mixed":
                    if (season == "Winter")
                        sport = "Ski";
                    else if (season == "Spring")
                        sport = "Cycling";
                    else if (season == "Summer")
                        sport = "Swimming";
                    break;
            }

            price *= participants * nights;
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
