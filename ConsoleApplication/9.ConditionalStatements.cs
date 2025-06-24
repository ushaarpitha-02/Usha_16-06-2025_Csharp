using System;
class ConditionalStatements
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        string result = (number > 0) ? "Number is positive." : "Number is non-positive.";

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
        multiplication();
        looping();
        loops();
        Profession();
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
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote");
        }
    }
    static void multiplication()
    {
        Console.WriteLine("Enter a number to print its multiplication table:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
        Console.WriteLine("Multiplication table completed.");

    }
    static void looping()
    {
        Console.WriteLine("Enter the name:");
        string Name = Console.ReadLine();
        switch (Name)
        {
            case "Usha":
                Console.WriteLine("My name");
                break;
            case "Vinitha":
                Console.WriteLine("My nick name");
                break;
            case "Arpitha":
                Console.WriteLine("My last name");
                break;
            case "Yeddula":
                Console.WriteLine("My sur name");
                break;
            case "Vinni":
                Console.WriteLine("My sweet name");
                break;
            default:
                Console.WriteLine("Name not found.");
                break;

        }
        Console.WriteLine(Name + " is a valid name.");
    }
    static void loops()
    {
        Console.WriteLine("Enter  a student name:");
        string studentName = Console.ReadLine();
        Console.WriteLine("Enter the student marks:");
        int marks = Convert.ToInt32(Console.ReadLine());
        //int marks;
        switch (studentName)
        {
            case "Usha":
            case "Vinitha":
            case "Arpitha":
            case "Yeddula":
            case "Vinni":
            case "Teju":
                if (marks >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                }
                break;
            default:
                Console.WriteLine("Student not found in the database.");
                break;


        }
    }
    static void Profession()
    {
        Console.WriteLine("Enter your profession:");
        string profession = Console.ReadLine();
        int salary=0;
        
        switch (profession)
        {
            case "doctor":

                salary = 10000;
                break;
            case "engineer":
                salary = 20000;
                break;
            case "teacher":
                salary = 30000;
                break;
            case "artist":
                salary = 40000;
                break;
            default:
                Console.WriteLine("Profession not recognized.");
                break;
        }
        Console.WriteLine($"The salary for the {profession} is: {salary}.");
        
    }
    
   

   

}


