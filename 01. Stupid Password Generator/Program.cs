﻿using System;

namespace _01._Stupid_Password_Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int count = 0;

            for (int d1 = 1; d1 < n; d1++)
            {
                for (int d2 = 1; d2 < n; d2++)
                {
                    for (char l1 = 'a'; l1 < 'a' + i; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a' + i; l2++)
                        {
                            for (int d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++)
                            {
                                Console.Write($"{d1}{d2}{l1}{l2}{d3} ");
                                count++;
                            }
                        }
                    }
                }
            }
        }
    }
}
