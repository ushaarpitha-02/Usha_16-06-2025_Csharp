using System;
using System.Diagnostics;
class VarandDynamic
{
    static void Main()
    {
        int height = 6;
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Type of height: " + height.GetType());
       
        string name = "usha";
        Console.WriteLine("Name:" + name );
        Console.WriteLine("Type of name: " + name.GetType());

        double weight = 70.5;
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Type of weight: " + weight.GetType());

        string name1= "Arpitha";
        Console.WriteLine($"name1:{name1}");


        //var person; // This line will cause a compile-time error because 'var' requires an initializer

        var age = 25;
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Type of age: " + age.GetType());

        age = 30;
        Console.WriteLine("Age after change: " + age);

        var isEmployed = true;
        Console.WriteLine("Is Employed: " + isEmployed);
        Console.WriteLine("Type of isEmployed: " + isEmployed.GetType());

        var heightInMeters = 1.75;
        Console.WriteLine("Height in Meters: " + heightInMeters);
        Console.WriteLine("Type of heightInMeters: " + heightInMeters.GetType());

        var fullName = 20;
        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Type of fullName: " + fullName.GetType());

        fullName = 30; //fullName = "Arpitha Usha"; // Changing the value must be compatible with the original type
        Console.WriteLine("Full Name after change: " + fullName);

        dynamic dynamicVariable = "I am dynamic";
        Console.WriteLine("Dynamic Variable: " + dynamicVariable);
        Console.WriteLine("Type of dynamicVariable: " + dynamicVariable.GetType());
        dynamicVariable = 42; // Changing the type at runtime

        Console.WriteLine("Dynamic Variable after change: " + dynamicVariable);
        Console.WriteLine($"Type of dynamicVariable after change:  { dynamicVariable.GetType()}");

        dynamic ages = 31;
        Console.WriteLine("Ages: " + ages);
        Console.WriteLine("Type of ages: " + ages.GetType());

        ages = "harika"; // Changing the type at runtime
        Console.WriteLine("Ages after change: " + ages);
        Console.WriteLine("Type of ages: " + ages.GetType());

        dynamic person = 1;
        person = 3;
        Console.WriteLine("Person: " + person);// wherever we give the value it will take the last value
        person =4;

        dynamic fashion;// This line will not cause an error, but 'fashion' must be initialized before use


    }
}
