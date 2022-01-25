using System;
class IfDemo
{
    static void Main()
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b) Console.WriteLine("а меньше b");

        if (a == b) Console.WriteLine("этого никто не увидит");

        Console.WriteLine();
        c = a - b;

        Console.WriteLine("с содержит -1");

        if (с >= 0) Console.WriteLine("значение с неотрицательно");
        if (с < 0) Console.WriteLine("значение с отрицательно");

        Console.WriteLine();

        с = b - а;

        Console.WriteLine("с содержит 1");
        
        if (с >= 0) Console.WriteLine("значение с неотрицательно");
        if (с < 0) Console.WriteLine("значение с отрицательно ");
    }
}
