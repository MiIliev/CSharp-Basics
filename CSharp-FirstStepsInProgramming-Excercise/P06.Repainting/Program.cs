using System;

namespace P06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nylon: ");
            int nylon = int.Parse(Console.ReadLine());
            Console.Write("Paint: ");
            int paint = int.Parse(Console.ReadLine());
            Console.Write("Thinner: ");
            int thinner = int.Parse(Console.ReadLine());
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            double sumNylon = (nylon + 2) * 1.50;
            double sumPaint = (paint + paint * 0.1) * 14.5;
            double sumThinner = thinner * 5;
            double sumMaterials = sumNylon + sumPaint + sumThinner + 0.4;
            double salary = (sumMaterials * 0.3) * hours;
            double total = sumMaterials + salary;
            Console.WriteLine(total);
        }
    }
}
