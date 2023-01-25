using System;

namespace P01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: ");
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine(BGN);
        }
    }
}
