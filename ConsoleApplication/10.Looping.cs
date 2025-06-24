using System;
class Loops
{
    static void Main()
    {
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
            totalprice =totalprice+ prices[count];
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


}
