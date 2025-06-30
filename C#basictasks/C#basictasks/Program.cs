using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
class Basics
{
    static void Main()
    {
        //Preparing an string array

        string[] names = { "John", "Robert", "Chandra", "Peter" };
        //printing the array
        Console.WriteLine("Printing all the names in array");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        //Get the Third Employee from the Array
        Console.WriteLine( "3rd name :"+names[2]);
        //Check weather Second and Third employee Equals or not from the Array
        if (names[1]==names[2])
        {
            Console.WriteLine("Name2 is equal to name3");
        }
        else
        {
            Console.WriteLine("Name2 is not equal to name3");
        }
        //Check the employee whose name starts with “J” from the Array
        foreach(string name in names)
        {
            if(name.StartsWith("J"))
            {
                Console.WriteLine($"Name starts with J is:{name}");
            }
        }
        //Convert Employees List into single String
        List<string> list = new List<string> { "John","Robert","Chandra","Peter"};
        string listofnames= string.Join(",",list);
        Console.WriteLine($"listofnames:{listofnames}");
        //Replace the “Robert” with “Peter” in String
        names = list.ToArray();
        Console.WriteLine("names");
        foreach (string name in names)
        {
           
           Console.WriteLine (name);

        }
        for(int i= 0; i < names.Length; i++)
        {
            if (names[i]=="Robert")
            {
                names[i] = "Peter";
            }

        }
        Console.WriteLine("Replaced robert with peter in string:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        //Get the Employee whose name length is more that 4 charcters from the array
       foreach (string name in names)
        {
            if (name.Length>4)
            {
                Console.WriteLine(name);
            }
        }
        //create a string and get the names in which there are less than 4 characters
        string[] employees = {"Usha","Arpitha","Vinitha","Vinni","Joe","Vani","Hari","Teju" };
        foreach (string employee in employees)
        {
            if(employee.Length<5)
            { 
                Console.WriteLine(employee);
            }
        }
        //Diff b/w for and foreach 
        int num = 0;
        for(int i= 0;i<10;i++)// Best when you need to know the index or modify the elements of a collection.
        {
            num = num + 5;
            Console.WriteLine(num);
        }
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] + 5;  // Modifying each element
            Console.WriteLine(numbers[i]);
        }
        int[] integers = { 10, 20, 30, 40, 50 };

        foreach (int integer in integers)//Best for read-only iteration over elements in a collection.
        {
           // integers = integers + 10;  // Can't modify the original array
            Console.WriteLine(integer + 5);  
        }

        //Importance of looping?

        //Automation: Reduces manual repetition of tasks.
        // Scalability: Easily handle large sets of data.
        //Efficiency: Write clean, maintainable code.
        //Decision Making: Can combine with logic to process only certain data.

        Console.WriteLine("Even numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            if(i%2==0)
            {
                
                Console.WriteLine(i);
            }
        }
        // Benefit                         Description
        //   Code Reusability         Write once, run many times
        //Easy Data Handling              Process large datasets or collections
        //Cleaner Logic                  Avoid unnecessary repetition
        //Condition-based Repeats        Repeat until a condition is true


        //Floating data types?

        //Floating data types are used to store numbers that have decimal points
        //(i.e., non-integer values).
        //These types are essential when you need to represent real-world measurements
        //like weight, height, or money

        //Three floating data types
        //1.Float==>size-4 bytes,suffix-f,precision-7 decimal points,suiatble when memory is limited and precision is not critical
        float k = 21.9f;
        Console.WriteLine(k);

        //2.Double==>size-8 bytes,suffix-d,precision-15-16 decimals,most common for general purpose decimal numbers
        double g = 8.2435345d;
        Console.WriteLine(g);

        //3.Decimal==>sixe-16 bytes,precision-28-29 decimals,suffix-m,best for financial and monetory calculations where precision matters
        decimal price = 34.89m;
        Console.WriteLine(price);


        //Logical operators?
        //Logical operators in C# are used to perform logical operations (true/false decisions) on Boolean expressions.
        //They are crucial in making decisions, controlling flow, and evaluating complex conditions in programs.
        //Why Are Logical Operators Important?
        //Decision Making: They help determine whether a condition is true or false.

        //Control Flow: Used in if, while, for, and switch statements to control what your program does.

        //Combining Conditions: You can evaluate multiple conditions together.

        //Clean Code: Help avoid nested if statements and make conditions more readable.
        //Logical and(&&),Logical not(!),Logical or(||)
        //Logical AND(&&)
        int a = 10;
        int b = 20;
        if(a<b&&b>a)
        {
            Console.WriteLine(true);
        }
        //Logical NOT(!)
        bool israining=false;
        if(!israining)
        {
            Console.WriteLine("We will go outside");
        }
        //Logical OR(||)
        if(a==b||a<b)
        {
            Console.WriteLine(true);
        }

        //What Are Nullable Types in C#?
        // In C#, nullable types allow value types (like int, bool, double) to also represent null — meaning "no value" or "unknown".

        //Normally, value types cannot be null, unlike reference types(like strings, classes).Nullable types solve this limitation.

        //Why Use Nullable Types?
        //To store missing or optional values, especially in databases or user input.
        //To check whether a value has been set.
        //Useful in scenarios like forms, calculations, and external data sources(e.g., int? age = null; if user didn’t enter age).
        //We will use a ? symbol after the type name
        int? age = null;
        Console.WriteLine(age);//It gives nothing

        int? age1 = null;

        if (age.HasValue)
        {
            Console.WriteLine($"Age is {age.Value}");
        }
        else
        {
            Console.WriteLine("Age is not specified.");
        }

        int? score = null;
        int finalScore = score ?? 0; // If score is null, use 0

        Console.WriteLine(finalScore); // Output: 0


        //What is implicit conversation type ? 
        //In C#, implicit conversion (or implicit type conversion) is when the compiler automatically converts
        //a value from one data type to another without needing extra syntax.
        //This happens when the conversion is safe — meaning there's no risk of data loss.
        //Happens when converting from a smaller to a larger
        //No need for a cast or conversion method
        //int to long,float,double,decimal
        //float to double
        //char to int,long
        //byte to int,long
        int x = 10;
        double y = x;  // Implicit conversion from int to double

        Console.WriteLine(y); // Output: 10

        char letter = 'A';
        int ascii = letter;  // 'A' has ASCII value 65

        Console.WriteLine(ascii); // Output: 65

        double d = 9.5;
        //int i = d; // ❌ Error: Cannot implicitly convert double to int
        int l = (int)d;//Explicit cast but we will loose the decimal part and only integer will be displayed
        Console.WriteLine(l);

        //Calling methods
        int result1 = Sum(2,56,34);
        int result2 = Sum(100,234,546,3245636);

        Console.WriteLine($"Sum 1: {result1}"); 
        Console.WriteLine($"Sum 2: {result2}");

        //Calling
        Console.WriteLine(GetGrade(95));
        Console.WriteLine(GetGrade(70));
        Console.WriteLine(GetGrade(30));

        //Calling
        string res=CheckLoginStatus(true);
        Console.WriteLine(res);

        //Calling
        ShowMenu();

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        ExecuteChoice(choice);

        //Calling 
        Console.WriteLine("Choose a method type:");
        Console.WriteLine("1. Use if-else");
        Console.WriteLine("2. Use switch-case");
        Console.Write("Enter your choice: ");

        int methodChoice = Convert.ToInt32(Console.ReadLine());

        if (methodChoice == 1)
        {
            UseIfElse();
        }
        else if (methodChoice == 2)
        {
            UseSwitchCase();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }


    }
    //Method with params with return types.
    //In C#, the params keyword allows a method to accept a variable number of arguments as an array.
    //This is useful when you don’t know how many arguments a user might pass.

    //returnType MethodName(params dataType[] parameterName)

    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    //Methods with conditions (if elseif else)
    //In C#, you can use if, else if, and else inside methods to perform decision-based logic —
    //meaning the program takes different actions depending on the input

   
    // Method that returns a grade based on marks
    static string GetGrade(int marks)
    {
        if (marks >= 90)
        {
            return "Grade A";
        }
        else if (marks >= 75)
        {
            return "Grade B";
        }
        else if (marks >= 60)
        {
            return "Grade C";
        }
        else if (marks >= 40)
        {
            return "Grade D";
        }
        else
        {
            return "Fail";
        }
    }

    static string CheckLoginStatus(bool isLoggedIn)
    {
        if (isLoggedIn)
        {
            return "Welcome back!";
        }
        else
        {
            return "Please log in.";
        }
    }


    //methods with Conditions (switch case)

    static void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Greet");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("3. Show Date");
        Console.WriteLine("4. Exit");
    }

    static void ExecuteChoice(int option)
    {
        switch (option)
        {
            case 1:
                Greet();
                break;
            case 2:
                AddNumbers();
                break;
            case 3:
                ShowDate();
                break;
            case 4:
                Console.WriteLine("Exiting program...");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    static void Greet()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }

    static void AddNumbers()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum = {a + b}");
    }

    static void ShowDate()
    {
        Console.WriteLine($"Today's date is {DateTime.Now.ToShortDateString()}");
    }

    //Methods with if else if else and Switch case conditions.
    //Using if else if else if and switch case in same code

    // Method using if-else if-else
    static void UseIfElse()
    {
        Console.WriteLine("\n[IF-ELSE] Menu:");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Multiply Two Numbers");
        Console.WriteLine("3. Show Time");
        Console.Write("Enter your option: ");

        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            SayHello();
        }
        else if (option == 2)
        {
            MultiplyNumbers();
        }
        else if (option == 3)
        {
            ShowTime();
        }
        else
        {
            Console.WriteLine("Invalid option in if-else.");
        }
    }

    //  Method using switch-case
    static void UseSwitchCase()
    {
        Console.WriteLine("\n[SWITCH-CASE] Menu:");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Multiply Two Numbers");
        Console.WriteLine("3. Show Time");
        Console.Write("Enter your option: ");

        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                SayHello();
                break;
            case 2:
                MultiplyNumbers();
                break;
            case 3:
                ShowTime();
                break;
            default:
                Console.WriteLine("Invalid option in switch-case.");
                break;
        }
    }

    //method: Say Hello
    static void SayHello()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }

    //method: Multiply two numbers
    static void MultiplyNumbers()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result = {num1 * num2}");
    }

    //method: Show current time
    static void ShowTime()
    {
        Console.WriteLine($"Current Time: {DateTime.Now.ToShortTimeString()}");
    }
}











