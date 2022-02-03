using System;

class Comma {
    static void Main()  {
        int smallest, largest;
        int num;
        int i, j;

        num = 100;

        smallest = largest = 1;

        for(i=2, j=num/2; (i<=num/2)&(j>=2); i++,j--)   {
            if((smallest==1)&((num%i)==0))
            smallest = i;

            if((largest==1)&((num%j)==0))
            largest = j;
        }

        Console.WriteLine("Наибольший множитель: " + largest);
        Console.WriteLine("Наименьший множитель: " + smallest);
    }
}