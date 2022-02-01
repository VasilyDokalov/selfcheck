using System;

class ScopeDemo 
{
    static void Main()  {
        int x;

        x = 10;
        if(x == 10){
            int y = 20;

            Console.WriteLine("x и y: " + x + " " + y);
            x = y * 2;
        }
        Console.WriteLine("x равно " + x);
    }
}