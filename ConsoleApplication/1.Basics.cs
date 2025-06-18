    using System;


namespace PracticeApplication
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to my space");
            Console.WriteLine("This is a practice application for C# development.");
            Console.WriteLine("Feel free to explore and modify the code as you wish.");
            Console.WriteLine("Happy coding!");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
            Display();
            Show();
        }
        static void Display()
        {
            Console.WriteLine("You can display whatever you want here");
            Console.WriteLine("This is a simple method to demonstrate code structure.");
            Console.WriteLine("Enter the first name and last name");

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your full name is: " + fullName);


        }
        static void Show()
        {
            Console.WriteLine("This is another method to show additional information.");
            Console.WriteLine("You can add more functionality here as needed.");
            Console.WriteLine("For example, you can perform calculations or display more data.");
            Console.WriteLine("Feel free to modify this method to suit your needs.");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is: " + favoriteColor);
            Console.WriteLine("Thank you for using this practice application!");
            Console.WriteLine("Goodbye!");
            Console.WriteLine("Happy coding");
        }
    }
}
