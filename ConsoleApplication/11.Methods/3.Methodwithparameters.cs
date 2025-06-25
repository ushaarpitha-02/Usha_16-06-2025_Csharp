using System;
class MethodsWithParameters
{
    static void Main()
    {
        string Message = DisplayMessage("Hi Vinitha.... How are you?");


        MultiplyNumbers(20, 30);
        Console.WriteLine("Multiplication Result: " + MultiplyNumbers(20, 30));


        double area = CalculateArea(89);
        Console.WriteLine("Area of circle: " + area);

        int[] numbers = { 1, 2, 3, 4, 5 };
        PrintArray(numbers);
        PrintPersonInfo("Vinitha", 25);
        PrintGreeting("Vinitha");
        PrintGreeting("Vinitha", "Welcome");
        PrintSum(10, 20);
        PrintSum(10, 20, 30);
        PrintDetails("Vinitha", 25);
        PrintDetails("Vinitha", 25, "Chennai");

        Confession("I Love you");
        Console.WriteLine("Methods with parameters executed successfully.");


    }
    static string DisplayMessage(string message)
    {
        Console.WriteLine("Message: " + message);
        return message;
    }
    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }
    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    static void PrintArray(int[] numbers)
    {
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    static void PrintPersonInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    static void PrintGreeting(string name, string greeting = "Hello")
    {
        Console.WriteLine($"{greeting}, {name}!");
    }
    static void PrintSum(int a, int b, int c = 0)
    {
        int sum = a + b + c;
        Console.WriteLine("Sum: " + sum);
    }
    static void PrintDetails(string name, int age, string city = "Unknown")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    //using dynamic  
    static void Confession(dynamic confession)
    {
        Console.WriteLine("Confession: " + confession);

    }
}
