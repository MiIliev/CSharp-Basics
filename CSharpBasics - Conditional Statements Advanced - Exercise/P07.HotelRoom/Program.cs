using System;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double costStudio = 0;
            double costApartament = 0;
            if (month == "May" || month == "October")
            {
                if (days > 7 && days <= 14)
                {
                    costStudio = 50 * days * 0.95;
                    costApartament = 65 * days;
                }
                else if (days > 14)
                {
                    costStudio = 50 * days * 0.7;
                    costApartament = 65 * days * 0.9;
                }
                else
                {
                    costStudio = 50 * days;
                    costApartament = 65 * days;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (days > 14)
                {
                    costStudio = 75.20 * days * 0.8;
                    costApartament = 68.70 * days * 0.9;
                }
                else
                {
                    costStudio = 75.20 * days;
                    costApartament = 68.70 * days;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (days > 14)
                {
                    costStudio = 76 * days;
                    costApartament = 77 * days * 0.9;
                }
                else
                {
                    costStudio = 76 * days;
                    costApartament = 77 * days;
                }
            }
            Console.WriteLine($"Apartment: {costApartament:f2} lv.");
            Console.WriteLine($"Studio: {costStudio:f2} lv.");
        }
    }
}
