using System;

namespace P11.TradeComissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comissions = 0;
            bool cityIsValid = city == "Sofia" || city == "Varna" || city == "Plovdiv";
            bool salesIsValid = sales >= 0;
            if (cityIsValid && salesIsValid)
            {
                switch (city)
                {
                    case "Sofia":
                        if (sales >= 0 && sales <= 500)
                            comissions = sales * 0.05;
                        else if (sales > 500 && sales <= 1000)
                            comissions = sales * 0.07;
                        else if (sales > 1000 && sales <= 10000)
                            comissions = sales * 0.08;
                        else if (sales > 10000)
                            comissions = sales * 0.12;
                        break;
                    case "Varna":
                        if (sales >= 0 && sales <= 500)
                            comissions = sales * 0.045;
                        else if (sales > 500 && sales <= 1000)
                            comissions = sales * 0.075;
                        else if (sales > 1000 && sales <= 10000)
                            comissions = sales * 0.1;
                        else if (sales > 10000)
                            comissions = sales * 0.13;
                        break;
                    case "Plovdiv":
                        if (sales >= 0 && sales <= 500)
                            comissions = sales * 0.055;
                        else if (sales > 500 && sales <= 1000)
                            comissions = sales * 0.08;
                        else if (sales > 1000 && sales <= 10000)
                            comissions = sales * 0.12;
                        else if (sales > 10000)
                            comissions = sales * 0.145;
                        break;
                }
                Console.WriteLine($"{comissions:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
