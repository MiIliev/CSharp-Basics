using System;

namespace P07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int roomArea = width * length * height;
            int remainingFreeArea = roomArea;
            while (remainingFreeArea > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                else
                {
                    int boxes = int.Parse(input);
                    remainingFreeArea -= boxes;
                }
            }
            if (remainingFreeArea > 0)
            {
                Console.WriteLine($"{remainingFreeArea} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(remainingFreeArea)} Cubic meters more.");
            }
        }
    }
}
