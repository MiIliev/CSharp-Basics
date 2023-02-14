using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowRange = int.Parse(Console.ReadLine());
            int highRange = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int result = 0;
            bool magicNumberFound = false;
            for (int x1 = lowRange ; x1 <= highRange; x1++)
            {
                for (int x2 = lowRange; x2 <= highRange; x2++)
                {
                    result = x1 + x2;
                    counter++;
                    if (result == magicNumber)
                    {
                        magicNumberFound = true;
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {result})");
                        break;
                    }    
                }
                if (magicNumberFound)
                {
                    break;
                }
            }
            if (magicNumberFound == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
