using System;
class DatatypeConversions
{
    static void Main()
    {
        /*
    Implicit Type Conversion (Type Promotion)
    It occurs when you convert a smaller data type into a larger data type without the risk of losing data.

    Datatype    Maximum value  
    Integral Types (Whole Numbers Only)
    byte        0 to 255
    int         ±2,147,483,648 or -2,147,483,648 to +2,147,483,647
    uint        0 to 4,294,967,295  
    long        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  
    ulong       0 to 18,446,744,073,709,551,615  

    Floating-Point Types (Fractional Values Allowed)
    decimal     ±79,228,162,514,264,337,593,543,950,335  
    float       ±3.40282347E+38F  
    double      ±1.7976931348623157E+308 
    */



        byte smallNumber = 100;
        int LargeNumber = smallNumber; // Implicit conversion from byte to int
        Console.WriteLine("Implicit Conversion from byte to int: " + LargeNumber);

        int NoOfEmployees = 400;
        byte ConvertingNoOfEmployees = (byte)NoOfEmployees;
        Console.WriteLine(ConvertingNoOfEmployees);

        double price = 99.99;
        int cost = (int)price;
        Console.WriteLine(cost);

        int numb = 76;
        string strNumber = numb.ToString();
        Console.WriteLine(strNumber.GetType());
        Console.WriteLine("Converted int to string: " + strNumber);


        string number = "100";
        int parsedNumber = int.Parse(number);
        Console.WriteLine(parsedNumber);
        Console.WriteLine(parsedNumber.GetType());

        string number1 = "234";
        int convertNumber = Convert.ToInt32(number1);
        Console.WriteLine(convertNumber);
        Console.WriteLine(convertNumber.GetType());

        string nullbaleString = null;
        int output1 = Convert.ToInt32(nullbaleString);
        Console.WriteLine(output1);
        Console.WriteLine(output1.GetType());


        DateTime dateTime = DateTime.Now;
        //Console.WriteLine("Current Date and Time: " + dateTime);
        Console.WriteLine(dateTime.ToString());

        string[] strings;
        strings = new string[] { "1", "2", "3" };
        int[] numbers = Array.ConvertAll(strings, int.Parse);
        Console.WriteLine("Converted string array to int array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        string str = "123456";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();

        int num1 = 10; //num1 directly stores the value 10
        string digit = "Ten"; // digit directly stores the value "Ten"

        int num2 = 20;
        object obj = num2; // object is the refereence type that can hold any data type
        Console.WriteLine("Object type: " + obj.GetType());

        int num3 = (int)obj;
        Console.WriteLine("Converted object back to int: " + num3);




        
    }
}

