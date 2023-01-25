using System;

namespace P06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());
            double pricePalamud = priceSkumriq * 1.6; //8.88
            double priceSafrid = priceCaca * 1.8; // 6.426
            double totalPriceMidi = kgMidi * 7.50; 
            double totalPricePalamud = pricePalamud * kgPalamud; 
            double totalPriceSafrid = priceSafrid * kgSafrid;
            double totalPrice = totalPricePalamud + totalPriceSafrid + totalPriceMidi;
            Console.WriteLine(totalPrice.ToString("0.00"));
         }
    }
}
