using System;
class BreakDemo {
    static void Main()  {
        for(int i=-10; i<=10; i++)  {
            if(i>0) break;
            Console.Write(i + " ");
        }
        Console.WriteLine("Готово!");
    }
}