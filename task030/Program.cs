using System;

class ForVar    {
    static void Main()  {
        double sum = 1;
        double fact = 1;

        for(double i=1; i<=5; i++) {
            sum += i;
            fact *=i;
        }

        Console.WriteLine("Сумма равна " + sum);
        Console.WriteLine("Факториал равен " + fact);
    }
}