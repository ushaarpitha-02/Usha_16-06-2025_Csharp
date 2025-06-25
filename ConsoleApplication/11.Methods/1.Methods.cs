using System;
using System.Data.SqlTypes;
class Methods
{
    static void Main()
    {
        Console.WriteLine("Welcome to methods");
        Method1();
       // Method2();

    }
    static void Method1()
    {
        Method2();
        Console.WriteLine("Method1 is executed");
        int i = 0;
        Console.WriteLine(i);
        

    }

    static void Method2()
    {
        Console.WriteLine("Method2 is executed");
        int[] money = {125,234,100,456};
        foreach(int rupee in money)
        {
            Console.WriteLine(rupee);
        }

        
    }
}