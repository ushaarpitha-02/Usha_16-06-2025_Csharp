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



            


            int p = 5;
            double q = a / 2;
            Console.WriteLine(b); //What is printed?



            string c = "";
            string d = null;
            Console.WriteLine(c == d); //What’s printed?

            bool isTrue = false;
            if (isTrue = true)
            {
                Console.WriteLine("True!");// Will this print "True!" ?
            }




            int x = 10;
            {
                int x = 20; //Will this compile?
                Console.WriteLine(x);
            }
        }
    }
}
