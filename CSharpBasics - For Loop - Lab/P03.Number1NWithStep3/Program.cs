﻿using System;

namespace P03.Number1NWithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i<= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
