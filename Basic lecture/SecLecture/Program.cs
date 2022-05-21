using System;

namespace SecLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long productOne = (long)firstNum + secondNum;
            long productTwo = productOne / thirdNum;
            long producThree = productTwo * fourthNum;

            Console.WriteLine(producThree);
        }
    }
}
