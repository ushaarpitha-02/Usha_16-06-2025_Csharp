using System;
class ConditionalStatements
{
    static void Main()
    {
        string[] names = { "Usha", "Vinitha", "Arpitha", "Yeddula", "Vinni" };
        int namesLength = names.Length;
        Console.WriteLine(names);
        foreach (string name in names)
        {
            //Console.WriteLine(name);
            if (name == "Vinni")
            {
                Console.WriteLine("Name found: " + name);
            }
        }
        Statements();
        Conditionals();
        SwitchStatement();
        switchstatements();
        ifstatements();
        righttovote();



    }
    static void Statements()
    {
        int number = 10;
        // if statement
        if (number > 0)
        {
            Console.WriteLine("Number is positive.");
        }
        // if-else statement
        if (number < 0)
        {
            Console.WriteLine("Number is negative.");
        }
        else
        {
            Console.WriteLine("Number is non-negative.");
        }
        // switch statement
        switch (number)
        {
            case 0:
                Console.WriteLine("Number is zero.");
                break;
            case 10:
                Console.WriteLine("Number is ten.");
                break;
            default:
                Console.WriteLine("Number is neither zero nor ten.");
                break;
        }
    }
    static void Conditionals()
    {
        Console.WriteLine("Enter a number:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (inputNumber < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }


    }
    static void SwitchStatement()
    {
        Console.WriteLine("Enter a day number (1-7):");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number.");
                break;
        }
    }
    static void switchstatements()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 10: Console.WriteLine("Ten"); break;
            default: Console.WriteLine("Number is not between 1 and 10"); break;

        }

    }
    static void ifstatements()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        // Using if statements to determine age category

        if (age == 0)

        {
            Console.WriteLine("You are a newborn.");
        }
        if (age == 1 || age == 2)
        {
            Console.WriteLine("You are a toddler.");
        }
        if (age >= 3 && age <= 12)
        {
            Console.WriteLine("You are a child.");
        }
        if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a teenager.");
        }
        if (age >= 20 && age <= 64)
        {
            Console.WriteLine("You are an adult.");
        }
        if (age >= 65)
        {
            Console.WriteLine("You are a senior citizen.");
        }
        if (age < 0)
        {
            Console.WriteLine("Invalid age entered.");
        }


    }
    static void righttovote()
    {
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age>=18)
        {
            Console.WriteLine("You are eligible to vote");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote");
        }
    }
}


