using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            int lenght = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Percentage: ");
            double percEntered = double.Parse(Console.ReadLine());
            double percentage = percEntered / 100;
            double tankVolumeCm = lenght * width * height;
            double tankVolumeL = tankVolumeCm / 1000;
            double freeSpace = tankVolumeL * (1 - percentage);
            Console.WriteLine(freeSpace);
        }
    }
}
