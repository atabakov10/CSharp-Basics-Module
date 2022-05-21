using System;

namespace Harder_than_the_usual_harder_excs
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premierePrice = 12.00;
            const double normalPrice = 7.50;
            const double discountPrice = 5.00;
            //            ⦁	Premiere – премиерна прожекция, на цена 12.00 лева.
            //⦁	Normal – стандартна прожекция, на цена 7.50 лева.
            //⦁	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double totalMoneyMade = 0;

            //logic for solving the current problem
            switch (typeOfProjection)
            {
                case "Premiere":
                    totalMoneyMade = rows * cols * premierePrice;
                    break;
                case "Normal":
                    totalMoneyMade = rows * cols * normalPrice;
                    break;
                case "Discount":
                    totalMoneyMade = rows * cols * discountPrice;
                    break;

            }
            Console.WriteLine($"{totalMoneyMade:f2} leva");

        }
    }
}
