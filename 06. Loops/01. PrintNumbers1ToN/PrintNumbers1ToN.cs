﻿using System;

class PrintNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("The End!");
    }
}

