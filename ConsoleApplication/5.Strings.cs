using System;
class Strings
{
    static void Main()
    {
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
}