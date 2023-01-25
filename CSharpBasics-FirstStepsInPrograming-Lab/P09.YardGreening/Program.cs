using System;
using System.Diagnostics;

namespace P09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area=double.Parse(Console.ReadLine());
            double costDiscountFalse = area * 7.61;
            double discountAmount = 0.18 * costDiscountFalse;
            double costDiscountTrue = costDiscountFalse - discountAmount;
            Console.WriteLine($"The final price is: {costDiscountTrue} lv.");
            Console.WriteLine($"The discount is: {discountAmount} lv.");
        }
    }
}
