using System;

namespace P05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Width: ");
            double widthM = double.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            double heightM = double.Parse(Console.ReadLine());
            double widthCM = widthM * 100;
            double heightCM = heightM * 100;
            double availableHeight = heightCM - 100;
            double seatsHeight = Math.Floor(availableHeight / 70);
            double seatsWidth = Math.Floor(widthCM / 120);
            Console.WriteLine(seatsWidth * seatsHeight - 3);
        }
    }
}
