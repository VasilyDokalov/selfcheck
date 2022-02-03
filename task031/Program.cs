using System;

class WhileDemo {
    static void Main()  {
        int num;
        int mag;

        num = 435678;
        mag = 0;

        Console.WriteLine("Число: " + num);

        while(num > 0)  {
            mag++;
            num = num/10;
        };
        Console.WriteLine("Порядок величины: " + mag);
    }
}