using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceInDollarsForProcessor = double.Parse(Console.ReadLine());
            double priceInDollarsForVidCard = double.Parse(Console.ReadLine());
            double priceInDollarsForRAM = double.Parse(Console.ReadLine());
            int numberRAM = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double priceInLevaForProcessor = priceInDollarsForProcessor * 1.57;
            double priceInLevaForVidCard = priceInDollarsForVidCard * 1.57;
            double priceInLevaForRAM = priceInDollarsForRAM * 1.57;
            double totalSumRAM = priceInLevaForRAM * numberRAM;
            double priceInLevaForProcessorAfterDisc = priceInLevaForProcessor - priceInLevaForProcessor * discount;
            double priceInLevaForVidCardAfterDisc = priceInLevaForVidCard - priceInLevaForVidCard * discount;
            double totalPrice = priceInLevaForProcessorAfterDisc + priceInLevaForVidCardAfterDisc + totalSumRAM;
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
