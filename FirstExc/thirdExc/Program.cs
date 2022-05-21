using System;

namespace thirdExc
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPpl = int.Parse(Console.ReadLine());
            var typeOfGroup = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            double price = 0.00;

            if (typeOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }

            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
            }
            double totalPrice = countOfPpl * price;
            double discount = 0.00;
            if (typeOfGroup == "Regular" && countOfPpl >= 10 && countOfPpl <= 20)
            {
                discount = totalPrice * 0.05;
            }
            else if (typeOfGroup == "Business" && countOfPpl >= 100)
            {
                discount = 10 * price;
            }
            else if (typeOfGroup == "Students" && countOfPpl >= 30)
            {
                discount = totalPrice * 0.15;
            }
            Console.WriteLine($"Total price: {totalPrice - discount:f2}");
        }
    }
}
