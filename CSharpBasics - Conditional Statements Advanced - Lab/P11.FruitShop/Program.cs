using System;

namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double fruitPrice = 0;

            bool dayIsValid = day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday";
            bool isWorkingDay = day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday";

            bool fruitIsValid = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" ||
                fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";

            if (dayIsValid && fruitIsValid)
            {
                if (isWorkingDay)
                {
                    if (fruit == "banana")
                        fruitPrice = 2.5;
                    else if (fruit == "apple")
                        fruitPrice = 1.20;
                    else if (fruit == "orange")
                        fruitPrice = 0.85;
                    else if (fruit == "grapefruit")
                        fruitPrice = 1.45;
                    else if (fruit == "kiwi")
                        fruitPrice = 2.7;
                    else if (fruit == "pineapple")
                        fruitPrice = 5.5;
                    else if (fruit == "grapes")
                        fruitPrice = 3.85;
                }
                else
                {
                    if (fruit == "banana")
                        fruitPrice = 2.7;
                    else if (fruit == "apple")
                        fruitPrice = 1.25;
                    else if (fruit == "orange")
                        fruitPrice = 0.9;
                    else if (fruit == "grapefruit")
                        fruitPrice = 1.6;
                    else if (fruit == "kiwi")
                        fruitPrice = 3;
                    else if (fruit == "pineapple")
                        fruitPrice = 5.6;
                    else if (fruit == "grapes")
                        fruitPrice = 4.2;
                }
                double totalAmount = fruitPrice * quantity;
                Console.WriteLine($"{totalAmount:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
