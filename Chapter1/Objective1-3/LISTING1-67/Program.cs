﻿using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-67 A for loop with a break statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for(int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) break;

                Console.WriteLine(values[index]);
            }
        }
    }
}
