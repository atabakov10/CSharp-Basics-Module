﻿using System;

namespace SecExc
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int divider = -1;

            if (num % 10 == 0)
            {
                divider = 10;
            }
            else if (num % 7 == 0)
            {
                divider = 7;
            }
            else if (num % 6 == 0)
            {
                divider = 6;
            }
            else if (num % 3 == 0)
            {
                divider = 3;
            }
            else if (num % 2 == 0)
            {
                divider = 2;
            }
            if (divider == -1)
            {
                Console.WriteLine("Not divisble");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
        }
    }
}
