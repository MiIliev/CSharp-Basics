using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 20 * months;
            double internet = 15 * months;

            for (int i = 0; i < months; i++)
            {
                double electricityMonthly = double.Parse(Console.ReadLine());
                electricity += electricityMonthly;
            }

            double others = (electricity + water + internet) * 1.2;
            double average = (electricity + water + internet + others) / months;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }   
    }
}
