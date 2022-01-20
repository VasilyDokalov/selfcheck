using System;

class BoolDemo {
    static void Main() {
        
        bool b;
        b = false;
        Console.WriteLine("b равно " + b);
        b = true;
        Console.WriteLine("b равно " + b);

        if(b) Console.WriteLine("Выполняется.");

        b = false;

        if(b) Console.WriteLine("Не выполняется.");

        Console.WriteLine(" 10 > 9 равно " + (10 > 9));
    }
}