using System;

namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberA = int.Parse(Console.ReadLine());
            double numberB = int.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());
            double result = 0;
            switch (o)
            {
                case '+':
                    result = numberA + numberB;
                    break;
                case '-':
                    result = numberA - numberB;
                    break;
                case '*':
                    result = numberA * numberB;
                    break;
                case '/':
                    if (numberB != 0)
                        result = numberA / numberB;
                    break;
                case '%':
                    result = numberA % numberB;
                    break;

            }
            bool isEven = result % 2 == 0;
            if (isEven)
            {
                switch (o)
                {
                    case '+':
                        Console.WriteLine($"{numberA} + {numberB} = {result} - even");
                        break;
                    case '-':
                        Console.WriteLine($"{numberA} - {numberB} = {result} - even");
                        break;
                    case '*':
                        Console.WriteLine($"{numberA} * {numberB} = {result} - even");
                        break;
                    case '/':
                        if (numberB != 0)
                            Console.WriteLine($"{numberA} / {numberB} = {result:f2}");
                        else
                            Console.WriteLine($"Cannot divide {numberA} by zero");
                        break;
                    case '%':
                        if (numberB != 0)
                            Console.WriteLine($"{numberA} % {numberB} = {result}");
                        else
                            Console.WriteLine($"Cannot divide {numberA} by zero");
                        break;
                }
            }
            else
            {
                switch (o)
                {
                    case '+':
                        Console.WriteLine($"{numberA} + {numberB} = {result} - odd");
                        break;
                    case '-':
                        Console.WriteLine($"{numberA} - {numberB} = {result} - odd");
                        break;
                    case '*':
                        Console.WriteLine($"{numberA} * {numberB} = {result} - odd");
                        break;
                    case '/':
                        if (numberB != 0)
                            Console.WriteLine($"{numberA} / {numberB} = {result:f2}");
                        else
                            Console.WriteLine($"Cannot divide {numberA} by zero");
                        break;
                    case '%':
                        if (numberB != 0)
                            Console.WriteLine($"{numberA} % {numberB} = {result}");
                        else
                            Console.WriteLine($"Cannot divide {numberA} by zero");
                        break;
                }
            }
        }
    }
}
