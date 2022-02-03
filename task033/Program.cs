using System;
class DoWhileDemo
{
    static void Main()
    {
        int num;
        int nextdigit;

        num = 198;

        Console.WriteLine("Число: " + num);

        Console.Write("Число в обратном порядке: ");

        do  {
            nextdigit = num % 10;
            Console.Write(nextdigit);
            num /= 10;
        }   while(num>0);
        Console.WriteLine();
    }

}