﻿using System;

namespace PartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currIndex = startIndex; currIndex <= endIndex; currIndex++)
            {
                char currCh = (char)currIndex;
                Console.Write($"{currCh} ");
            }
        }
    }
}
