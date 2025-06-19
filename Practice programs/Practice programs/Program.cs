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

            Console.WriteLine("Count no of words in sentence");
            Console.WriteLine("Enter a sentence :");
            string CountWords = Console.ReadLine();
            string[] splittedWords = CountWords.Split(' ');
            int wordCount = splittedWords.Length;
            Console.WriteLine("Number of words in the sentence:" + wordCount);


            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Length of the sentence is: {sentence.Length}");

            string sentence1 = "software engineers are going to shine in the future";
            Console.WriteLine(sentence1);
            Console.WriteLine($"Length of the sentence1 is:{sentence1.Length}");




        }
    }
}
