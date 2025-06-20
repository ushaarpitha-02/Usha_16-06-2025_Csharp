using System;


namespace Practice_programs
{
     class Program
    {
        static void Main()
        {
            int a = 5;  
            int b = a++;
            Console.WriteLine($"{a}, {b}");
            //the outpur will be 6, 5 because a is incremented after the assignment to b






            int p = 5;
            double q = p / 2;
            Console.WriteLine(q); //What is printed?
            //The output will be 2 because p is an integer and the division will be performed as integer division, resulting in 2, which is then converted to double.


            string c = "";
            string d = null;
            Console.WriteLine(c == d); //What’s printed?
            //The output will be False because an empty string "" is not equal to null.

            bool isTrue = false;
            if (isTrue = true)
            {                
                Console.WriteLine("True!");// Will this print "True!" ?
                //Yes, it will print "True!" because the assignment `isTrue = true` evaluates to true, and the if condition is satisfied.
            }

            int x = 10;
            int y = 20;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"x = {x}, y = {y}"); //20  10


            int v = 7;
            Console.WriteLine($"value of v is :" + v++);  
            Console.WriteLine($"value of v is :" + ++v);// 7 9

            int u = 5;
            bool result = !(u > 2 && u < 10);
            Console.WriteLine(result);//false

            

        }
        
    }
}
