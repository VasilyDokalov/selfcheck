using System;
class Ladder    {
    static void Main()  {
        int num;

        for(num=12;num>2;num--) {
            if((num%2)==0)
            Console.WriteLine("Наименьший множитель числа " + num + " равен 2.");
            else if((num%3)==0)
            Console.WriteLine("Наименьший множитель числа " + num + " равен 3.");
            else if((num%5)==0)
            Console.WriteLine("Наименьший множитель числа " + num + " равен 5.");
            else if((num%7)==0)
            Console.WriteLine("Наименьший множитель числа " + num + " равен 7.");
            else 
            Console.WriteLine(num + " не делится на 2, 3, 5 или 7.");
        }
    }
}