using System;

namespace P08.Fuel_Tank_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            switch (fuel)
            {
                case "Gas":
                    switch (clubCard)
                    {
                        case "Yes":
                            if (liters >= 20 && liters <= 25)
                            {
                                gas = (gas - 0.08) * liters * 0.92;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                gas = (gas - 0.08) * liters * 0.90;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            else
                            {
                                gas = (gas - 0.08) * liters;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            break;
                        case "No":
                            if (liters >= 20 && liters <= 25)
                            {
                                gas *= liters * 0.92;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                gas *= liters * 0.9;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            else
                            {
                                gas *= liters;
                                Console.WriteLine($"{gas:f2} lv.");
                            }
                            break;
                    }
                    break;

                case "Gasoline":
                    switch (clubCard)
                    {
                        case "Yes":
                            if (liters >= 20 && liters <= 25)
                            {
                                gasoline = (gasoline - 0.18) * liters * 0.92;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                gasoline = (gasoline - 0.18) * liters * 0.9;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            else
                            {
                                gasoline = (gasoline - 0.18) * liters;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            break;
                        case "No":
                            if (liters >= 20 && liters <= 25)
                            {
                                gasoline *= liters * 0.92;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                gasoline *= liters * 0.90;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            else
                            {
                                gasoline *= liters;
                                Console.WriteLine($"{gasoline:f2} lv.");
                            }
                            break;
                    }
                    break;

                case "Diesel":
                    switch (clubCard)
                    {
                        case "Yes":
                            if (liters >= 20 && liters <= 25)
                            {
                                diesel = (diesel - 0.12) * liters * 0.92;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                diesel = (diesel - 0.12) * liters * 0.9;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            else
                            {
                                diesel = (diesel - 0.12) * liters;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            break;
                        case "No":
                            if (liters >= 20 && liters <= 25)
                            {
                                diesel *= liters * 0.92;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            else if (liters > 25)
                            {
                                diesel *= liters * 0.9;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            else
                            {
                                diesel *= liters;
                                Console.WriteLine($"{diesel:f2} lv.");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
