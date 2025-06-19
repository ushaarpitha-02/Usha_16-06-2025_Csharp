using System;
class Strings
{
    static void Main()
    {
        Strings1();
        string name = "Usha";
        Console.WriteLine($"My name is : {name} Arpitha");

        string fullName = "\"Yeddula Usha Arpitha\"";
        Console.WriteLine($"My full name is : {fullName}");

        string aboutMySelf = "I \nam \na \nsoftware \ndeveloper";
        Console.WriteLine($"{aboutMySelf}");

        string projectPath = @"C:\Users\Usha\Documents\Projects\MyProject";
        Console.WriteLine($"Project Path: {projectPath}");


        string soul = "Vinitha"; 
        int age = 25;
        Console.WriteLine($"My soul is {soul} and I am {age} years old");// we can give like this but for better understading purpose we have access the already formed strings
        var mySelf = "Usha Arpitha";
        var age1 = 25;
        string mySoul = $"My name is {mySelf} and I am {age1} years old";
        Console.WriteLine(mySoul);// this is the best way to access the already formed strings

        var myFriend = "Teju";
        var myFriendAge = 17;
        var myFriendStudies = "CA";
        var myFriendFamily= "Father, Mother";
        Console.WriteLine($"My friend's name is {myFriend}, she is {myFriendAge} years old, she is studying {myFriendStudies} and her family members are {myFriendFamily}.");
        



    }
    static void Strings1()
    {
        string sentence = "Human Being should show some Humanity if they want to be called as Human Being";
        Console.WriteLine(sentence);// We can use this in other format also as shown in next statement
        Console.WriteLine($"{sentence}");
        int length = sentence.Length;
        Console.WriteLine("Length of the sentence is:" + length);

        string lowercase = sentence.ToLower();
        Console.WriteLine($"Lowercase of the sentence is:{lowercase}");


        string uppercase = sentence.ToUpper();
        Console.WriteLine($"Uppercase of the sentence is:{uppercase}");

        string name = "     CSHARP     ";
        Console.WriteLine(name);

        Console.WriteLine($"Trimming the string is:{name.Trim()}");
        Console.WriteLine($"Trimming the begin of the string is:{name.TrimStart()}");
        Console.WriteLine($"Trimming the end of the string is:{name.TrimEnd()}");

        Console.WriteLine($"Padding the string is:{name.PadLeft(20, '*')}");
        Console.WriteLine($"Padding the string is:{name.PadRight(20, '*')}");


        string password = "Usha@123";
        Console.WriteLine(password);
        bool isequal = password.Equals("Usha#123");
        Console.WriteLine($"Is the password equal to Usha@123? {isequal}");

        string sentence1= "software engineers are going to shine in the future";
        Console.WriteLine(sentence1);
        Console.WriteLine($"Length of the sentence1 is:{sentence1.Length}");
       
        string substring = sentence1.Substring(0, 8);
        Console.WriteLine($"Substring of the sentence is: {substring}");
        Console.WriteLine($"Substring of the sentence is: {sentence1.Substring(9, 8)}");
        
        int index = sentence1.IndexOf("shine");
        Console.WriteLine($"Index of the word 'shine' in the sentence is: {index}");
        string[] words = sentence1.Split(' ');
        Console.WriteLine("Words in the sentence are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string profession= "Software Engineer";
        Console.WriteLine($"Profession is: {profession}");
        string replacedstring = profession.Replace("Engineer", "Developer");
        Console.WriteLine($"Replaced string is :{replacedstring}");

        int quantity = 19;
        double price = 79.8;

        string receipt = string.Format("You purcahsed {0} items for {1}", quantity, quantity * price);
        Console.WriteLine(receipt);

        string data = "apple,banana,cherry";
        string[] fruitsList = data.Split(',');
        Console.WriteLine(fruitsList);

        

    }
}