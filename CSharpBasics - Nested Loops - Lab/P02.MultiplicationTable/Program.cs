using System;

namespace P02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 11; a++)
            {
                for (int b = 1; b < 11; b++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }
        }
    }
}
