using System;
class BlockDemo
{
    static void Main()
    {
        int i, j, d;
        
        i = 5;
        j = 10;

        if (i != 0)
        {
            Console.WriteLine("i не равно нулю");
            d = j / i;
            Console.WriteLine("j / i равно " + d);
        }
    }
}
