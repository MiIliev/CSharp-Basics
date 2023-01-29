using System;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTournaments = int.Parse(Console.ReadLine());
            double startingPoints = double.Parse(Console.ReadLine());
            double pointsWon = 0;
            double tournamentsWon = 0;

            for (int i = 0; i < countTournaments; i++)
            {
                string stage = Console.ReadLine();
                switch (stage)
                {
                    case "W":
                        tournamentsWon++;
                        pointsWon += 2000;
                        break;
                    case "F":
                        pointsWon += 1200;
                        break;
                    case "SF":
                        pointsWon += 720;
                        break;
                }
            }

            double finalPoints = startingPoints + pointsWon;
            Console.WriteLine($"Final points: {finalPoints}");
            double averagePoints = pointsWon / countTournaments;
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            double percentageTournamentsWon = tournamentsWon / countTournaments * 100;
            Console.WriteLine($"{percentageTournamentsWon:f2}%");

        }
    }
}
