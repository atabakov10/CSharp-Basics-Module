using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;

            while (input != "NoMoreMoney")
            {
                double currentTransaction = double.Parse(input);
                if (currentTransaction <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;

                }

                Console.WriteLine($"Increase: {currentTransaction:f2}");
                totalMoney += currentTransaction;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
