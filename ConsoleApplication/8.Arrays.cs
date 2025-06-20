using System;
class Arrays
{
    static void Main()
    {
        //Creating and initializing an array with fixed size
        int[] numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine("Array length: " + numbers.Length);
        Console.WriteLine("Array type: " + numbers.GetType());
        // creating and initializing an array without fixed size

        int[] numbers1 = new int[] { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements without fixed size:");
        Console.WriteLine("0th number is :" + numbers1[0]);
        Console.WriteLine("1st number is :" + numbers1[1]);
        Console.WriteLine("2nd number is :" + numbers1[2]);
        Console.WriteLine("3rd number is :" + numbers1[3]);
        Console.WriteLine("4th number is :" + numbers1[4]);

        int[] integers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array elements without fixed size:");
        foreach (int number in integers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("Array length: " + integers.Length);
        Console.WriteLine("Array type: " + integers.GetType());
        // Creating a multidimensional array
        int[,] multiArray = new int[3, 3] { { 1, 2,3}, { 4, 5, 6 },{ 7,8,9} };
        Console.WriteLine("Multidimensional array elements:");
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Multidimensional array length: " + multiArray.Length);
        Console.WriteLine("Multidimensional array type: " + multiArray.GetType());
        

        string data = "Hello,World,This,Is,C#" ;
        string[] words = data.Split(',');
        Console.WriteLine("String array elements:"+ data);
        Console.WriteLine(words);//this will give the data type of the array
        //so we have to use loops to display the data in the array

        foreach(string word in words)
        {
            Console.WriteLine(word);
        }

        string   vegetables = "Tomato,Potato,Onion,Carrot,Cabbage";
        string[] vegetableArray = vegetables.Split(',');
        Console.WriteLine("Vegetable array elements:");
        foreach (string vegetable in vegetableArray)
        {
            Console.WriteLine(vegetable);
        }

        var fruits= "Apple,Banana,Orange,Grapes,Mango";
        foreach(var fruit in fruits)
        {
            Console.WriteLine(fruit); // This will not work as expected because fruits is a string, not an array
        }

        int[] currencynotes = { 100, 200, 500, 2000 };
        foreach(int note in currencynotes)
        {
            Console.WriteLine("Currency note: " + note);
        }
        foreach(var note in currencynotes)
        {
            int addedNote = 20;
            int totalNote = note + addedNote; // Adding 20 to each note
            Console.WriteLine("Currency note using var: " + totalNote); // This will work as expected
        }
        // Using var with arrays
        var numbersArray = new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Numbers array using var:");
        foreach (var num in numbersArray)
        {
            Console.WriteLine(num);
        }
        // Using var with a multidimensional array
        Console.WriteLine("Multidimensional array using var:");
        var multiArrayVar = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Multidimensional array elements:");
        for (int i = 0; i < multiArrayVar.GetLength(0); i++)
        {
            for (int j = 0; j < multiArrayVar.GetLength(1); j++)
            {
                Console.Write(multiArrayVar[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Using var with a string array
        var stringArray = new[] { "Hello", "World", "C#", "Arrays" };
        Console.WriteLine("String array using var:");
        foreach (var str in stringArray)
        {
            Console.WriteLine(str);
        }
        


    }
}