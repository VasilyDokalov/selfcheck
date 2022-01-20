using System;
class Example3
{
    static void Main()
    {
        int ivar; 
        double dvar; 

        ivar = 100; 

        dvar = 100.0; 

        Console.WriteLine("Исходное значение ivar: " + ivar);
        Console.WriteLine("Исходное значение dvar: " + dvar);
        
        Console.WriteLine(); 
                             
        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("Значение ivar после деления: " + ivar);
        Console.WriteLine("Значение dvar после деления: " + dvar);
    }
}
