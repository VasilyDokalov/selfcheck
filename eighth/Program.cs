﻿using System;
class ProdSum
{
    static void Main()
    {
        int prod;
        int sum;
        int i;

        sum = 0;
        prod = 1;
        
        for (i = 1; i <= 10; i++)
        {
            sum = sum + i;
            prod = prod * i;
        }
        Console.WriteLine("Сумма равна " + sum);
        Console.WriteLine("Произведение равно " + prod);
    }
}
