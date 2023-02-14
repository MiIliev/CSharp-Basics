using System;

namespace P06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = null;
            string ticketType = null;

            double totalTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;

            while ((movieName=Console.ReadLine()) != "Finish")
            {
                double freeSeats = int.Parse(Console.ReadLine());
                double remainingSeats = freeSeats;
                double totalTicketsCurrentMovie = 0;
                while (remainingSeats > 0 && (ticketType = Console.ReadLine()) != "End")
                {
                    totalTickets++;
                    totalTicketsCurrentMovie++;
                    remainingSeats--;
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidsTickets++;
                            break;
                    }
                }
                double percentageFullSeats = (totalTicketsCurrentMovie / freeSeats) * 100;
                Console.WriteLine($"{movieName} - {percentageFullSeats:f2}% full.");
                totalTicketsCurrentMovie = 0;
            }
            double percentageStudentTickets = (studentTickets / totalTickets) * 100;
            double percentageStandardTickets = (standardTickets / totalTickets) * 100;
            double percentageKidsTickets = (kidsTickets / totalTickets) * 100;
            Console.WriteLine($"Total tickets: {totalTickets}\n" +
                $"{percentageStudentTickets:f2}% student tickets.\n" +
                $"{percentageStandardTickets:f2}% standard tickets.\n" +
                $"{percentageKidsTickets:f2}% kids tickets.");
        }
    }
}
