﻿using System;

/// <summary>
/// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
/// </summary>
class WithAccuracyToThirdFloat
{
    static void Main()
    {
        double sum = 1.0f;
        for (double i = 2; 1 / i >= 0.001; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + 1 / i;
            }
            else
            {
                sum = sum - 1 / i;
            }
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}