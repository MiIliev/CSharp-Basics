using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double totalPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < juryCount && totalPoints < 1250.5; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                totalPoints += juryName.Length * juryPoints / 2;
            }
            if (totalPoints >= 1250.50)
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            else
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoints:f1} more!");
        }
    }
}
