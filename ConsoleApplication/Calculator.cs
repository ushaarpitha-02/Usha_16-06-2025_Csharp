using System;

class SimpleCalculator
{
    static void Main()
    {
        int choice;
        double num1, num2, result = 0;
        bool Menu = true;

        while (Menu)
        {
            
            Console.WriteLine("\n--- Simple Calculator ---");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                Menu = false;
                Console.WriteLine("Exiting...");
                break;
            }

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }

            Console.WriteLine("Result: " + result);
            Console.Write("Do you want to perform another operation? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes" && response != "y")
            {
                Menu = false;
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Continuing...");
            }

        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Subtract(double a, double b)
    {
        return a - b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Divide(double a, double b)
    {
        return a / b;
    }
}
