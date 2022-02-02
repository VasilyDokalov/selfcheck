using System;

class PosNegZero    {
    static void Main()  {
        int i;

        for(i=-5;i<=5;i++)  {
            Console.WriteLine("Проверка " + i + ": ");
            if(i<0) Console.WriteLine("отрицательное число");
            else if(i==0) Console.WriteLine("число без знака");
            else Console.WriteLine("положительное число");
        }
    }
}