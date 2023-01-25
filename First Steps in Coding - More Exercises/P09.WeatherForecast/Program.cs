using System;

namespace P09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string whether = Console.ReadLine();
            if (whether == "sunny")
            {Console.WriteLine("It's warm outside!"); }
            else 
            { Console.WriteLine("It's cold outside!"); }
        }
    }
}
