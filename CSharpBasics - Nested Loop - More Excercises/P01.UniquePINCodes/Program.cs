using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumberLimit = int.Parse(Console.ReadLine());
            int secondNumberLimit = int.Parse(Console.ReadLine());
            int thirdNumberLimit = int.Parse(Console.ReadLine());

            for (double firstNumber = 2; firstNumber <= firstNumberLimit; firstNumber += 2)
            {
                for (double secondNumber = 0; secondNumber <= secondNumberLimit; secondNumber++)
                {
                    if (secondNumber >= 2 && secondNumber <= 7)
                    {
                        bool isRealNumber = true;
                        for (double i = 2; i < secondNumber; i++)
                        {
                            if (secondNumber % i == 0)
                            {
                                isRealNumber = false;
                            }
                        }
                        if (isRealNumber && secondNumber >= 2 && secondNumber <= 7)
                        {
                            for (double thirdNumber = 2; thirdNumber <= thirdNumberLimit; thirdNumber += 2)
                            {
                                Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
                                isRealNumber = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
