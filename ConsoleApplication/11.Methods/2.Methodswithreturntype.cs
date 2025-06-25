using System;
class Methodswithreturntype
{
    static void Main()
    {
        string name = Method1();
        //method1 is called and its return value is assigned to the variable name
        Console.WriteLine(name);


        int age = Method2();
        // method2 is called and its return value is assigned to the variable age
        Console.WriteLine(age);

        Method3();// method3 is called, it does not return any value
        int sum = Method4(1090, 2780);
        // method4 is called with two integer arguments and its return value is assigned to the variable sum
        Console.WriteLine("The sum of 1090 and 2780 is: " + sum);

    }
    static string Method1()// string is a return type, it returns a string value
                           // this method returns a string value which is the name of the employee
    {
        string employeeName = "Usha";
        return employeeName;
    }

    static int Method2()// int is a return type, it returns an integer value
                        // this method returns an integer value which is the age of the employee
    {
        int employeeAge = 25;
        return employeeAge;
    }

    static void Method3()  //void does not return any value
                           // this method does not return any value, it just prints the details of the employee
    {
        Console.WriteLine("Usha is working in Misard and her Age is 25.");
    }
    static int Method4(int a, int b) // this method takes two integer parameters and returns their sum
    {
        return a + b; // returns the sum of a and b

    }
}

