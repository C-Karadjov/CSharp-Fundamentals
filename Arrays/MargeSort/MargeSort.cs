﻿namespace MargeSort
{
    using System;

    class MargeSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
