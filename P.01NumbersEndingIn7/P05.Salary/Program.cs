using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = openTabs; i > 0 && salary > 0; i--)
            {
                string tabName = Console.ReadLine();
                    switch (tabName)
                    {
                        case "Facebook":
                            salary -= 150;
                            break;
                        case "Instagram":
                            salary -= 100;
                            break;
                        case "Reddit":
                            salary -= 50;
                            break;
                    }
            }
            if (salary <= 0)
                Console.WriteLine("You have lost your salary.");
            else
                Console.WriteLine(salary);
        }
    }
}
