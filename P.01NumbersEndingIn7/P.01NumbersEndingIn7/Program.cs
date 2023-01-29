using System;

namespace P._01NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 998; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
