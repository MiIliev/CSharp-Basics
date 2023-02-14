using System;

namespace P02.LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char prohibitedLetter = char.Parse(Console.ReadLine());
            int firstLetterNumericValue = 0;
            int secondLetterNumericValue = 0;
            int prohibitedLetterNumericValue = 0;
            int combinationsCounter = 0;
            for (int i = 0; i < 26; i++)
            {
                char currentLetter = alphabet[i];
                if (currentLetter == firstLetter)
                {
                    firstLetterNumericValue = i;
                }
                if (currentLetter == secondLetter)
                {
                    secondLetterNumericValue = i;
                }
                if (currentLetter == prohibitedLetter)
                {
                    prohibitedLetterNumericValue = i;
                }
            }
            for (int firstChar = firstLetterNumericValue; firstChar <= secondLetterNumericValue; firstChar++)
            {
                if (firstChar != prohibitedLetterNumericValue)
                {
                    for (int secondChar = firstLetterNumericValue; secondChar <= secondLetterNumericValue; secondChar++)
                    {
                        if (secondChar != prohibitedLetterNumericValue)
                        {
                            for (int thirdChar = firstLetterNumericValue; thirdChar <= secondLetterNumericValue; thirdChar++)
                            {
                                if (thirdChar != prohibitedLetterNumericValue)
                                {
                                    Console.Write($"{alphabet[firstChar]}{alphabet[secondChar]}{alphabet[thirdChar]} ");
                                    combinationsCounter++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(combinationsCounter);
        }
    }
}
