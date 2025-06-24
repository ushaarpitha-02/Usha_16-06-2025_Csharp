using System;
class Loops
{
    static void Main()
    {
        Shopping();
        groceries();
        int number = 0;
        Console.WriteLine($"current number before looping:{number}");
        while (number < 10)
        {
            number = number + 2;
        }
        Console.WriteLine($"Current number is: {number}");

        int[] prices = { 123, 234, 345, 456, 567 };

        int count = 0;
        int totalprice = 0;
        while (count < prices.Length)
        {
            totalprice = totalprice + prices[count];
            count = count + 1;
        }
        Console.WriteLine($"Total price is: {totalprice}");


        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        int index = 0;
        while (index < numbers.Length)
        {
            sum = sum + numbers[index];
            index++;
        }


        Console.WriteLine($"Sum of numbers is: {sum}");

    }
    static void groceries()
    {

        Console.WriteLine("Groceries in the cart:");
        string[] groceries = { "Apples", "Bananas", "Oranges", "Milk", "Bread" };
        int index = 0;
        while (index < groceries.Length)
        {
            Console.WriteLine($"{index + 1}. {groceries[index]}");
            index++;
        }



        Console.WriteLine("Do you want to add more items? (yes/no)");

        string addMore = Console.ReadLine().ToLower();

        if (addMore == "yes")
        {
            Console.WriteLine("Enter the name of the item to add:");
            string newItem = Console.ReadLine();
            Array.Resize(ref groceries, groceries.Length + 1);
            groceries[groceries.Length - 1] = newItem;
            Console.WriteLine("Updated groceries list:");
            index = 0;
            while (index < groceries.Length)
            {
                Console.WriteLine($"{index + 1}. {groceries[index]}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("No more items added.");



        }
    }

    static void Shopping()
    {
        


        Console.WriteLine("Welcome to the clothing store!");
        string[] clothes = { "T-shirt", "Jeans", "Jacket", "Shoes" };
        int index = 0;
        while (index < clothes.Length)
        {
            Console.WriteLine($"{index + 1}. {clothes[index]}");
            index++;
        }

        
        Console.WriteLine("Please select an item to purchase by entering the number:");
        int selectedItem = Convert.ToInt32(Console.ReadLine()) - 1;
        if (selectedItem >= 0 && selectedItem < clothes.Length)
        {
            Console.WriteLine($"You selected: {clothes[selectedItem]}");
            Console.WriteLine("Please enter the price of the item:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have purchased {clothes[selectedItem]} for ${price}.");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
        
        Console.WriteLine("Please select a payment method:");
        Console.WriteLine("1. Cash");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        int paymentMethod = Convert.ToInt32(Console.ReadLine());
        switch (paymentMethod)
        {
            case 1:
                Console.WriteLine("You selected Cash. Please pay the amount in cash.");
                break;
            case 2:
                Console.WriteLine("You selected Credit Card. Please swipe your card.");
                break;
            case 3:
                Console.WriteLine("You selected Debit Card. Please insert your card.");
                break;
            default:
                Console.WriteLine("Invalid payment method selected.");
                break;
        }
        Console.WriteLine("Amount paid!!! Thank you for shopping with us!");

    }
}
