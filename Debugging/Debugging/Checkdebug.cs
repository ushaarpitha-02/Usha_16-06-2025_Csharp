using System;

class SoftwareOffice
{
    static void Main(string[] args)
    {
        PrintFirstCheckPoint();

        string empName = getEmpName();
        Console.WriteLine($"You can print now empName value in console window {empName}");

        string johnDetails = getJohnDetails();
        string lakshmiDeails = getLakshmiDetails();

        PrintAllCheckPointsList();

        getEmpDetailsByEmpName("John");


        Console.ReadLine();

    }

    static void PrintFirstCheckPoint()
    {
        Console.WriteLine("************  CheckPoint - 1 ***************");
        string empName = "John";
        int empAge = 35;
        decimal empSalary = 15000.98M;

        Console.WriteLine($"Showing the data before Check Point 2 : {empName} , {empAge} {empSalary}");
    }

    static string getEmpName()
    {
        string empName = "John";
        //string empName = Console.ReadLine();
        return empName;
    }

    static string getJohnDetails()
    {
        string details = "John is a Software Engineer from UK";
        return details;
    }

    static string getLakshmiDetails()
    {
        string details = "Lakshmi is a Software Trainee from India";
        return details;
    }

    static void PrintAllCheckPointsList()
    {
        Console.WriteLine("************  CheckPoint - 1 ***************");
        string empName = "John";
        int empAge = 35;
        decimal empSalary = 15000.98M;
        Console.WriteLine($"Showing the data before Check Point 2 : {empName} , {empAge} {empSalary}");


        Console.WriteLine("************  CheckPoint - 2 ***************");
        string Designation = "Software Engineer";
        string DOB = "Jun-04-1990";
        Console.WriteLine($"Showing the data before Check Point 3 : {Designation} , {DOB}");


        Console.WriteLine("**************  CheckPoint - 3 ****************");
        int[] empIDs = { 101, 102, 103 };
        string[] bankNames = { "HDFC", "Axis", "SBI" };
        Console.WriteLine("******You are at End of Block Now**************");

    }

    static string getEmpDetailsByEmpName(string empName)
    {
        string empDetails = "";
        string managerName = "Ram";

        //string data =  string.Concat("Hello ", "world"); //"Hello world";
        //data   =  string.Concat(data, "....");

        if (empName == "John")
        {
            empDetails = getJohnDetails();
            empDetails = string.Concat(empDetails, " John DOB is 12-Jan-1990");
            empDetails = string.Concat(empDetails, "Manager name is " + managerName);
        }
        else if (empName == "Lakshmi")
        {
            empDetails = getLakshmiDetails();
            empDetails = string.Concat(empDetails, " Lakshmi DOB is 23-Aug-2002");
            empDetails = string.Concat(empDetails, "Manager name is " + managerName);
        }
        else
        {
            empDetails = "No employee found";
        }

        return empDetails;
    }




}