using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            int currentSum = int.Parse(Console.ReadLine());

            while (currentSum < expectedSum)
            {
                currentSum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(currentSum);
        }
    }
}
