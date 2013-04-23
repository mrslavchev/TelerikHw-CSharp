﻿using System;

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("PLese enter five numbers:");
        int[] numbers = new int[5];
        int counter = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Number");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum += ((i >> j) & 1) * numbers[j];
            }
            if (sum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("And the subset sums equal to zero are {0}",counter);
    }
}