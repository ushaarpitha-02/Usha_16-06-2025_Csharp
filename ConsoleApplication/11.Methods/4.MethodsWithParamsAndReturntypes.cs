using System;
class MethodsWithParamsAndReturntypes
{
    static void Main()
    {
        string studentdetails = getStudentDetails(10);
        Console.WriteLine(studentdetails);


        int age = getStudentAgeByName("Varun");
        Console.WriteLine("His age is :" +age);

        string name = getStudentNameById(10);
        Console.WriteLine("His name is :" + name);
    }


    
    static string getStudentDetails(int id)
    {
        string studentDetails = $"Student Name is Varun And his Id is {id}";
        return studentDetails;
    }

    static int getStudentAgeByName(string name)
    {
        int age =31 ; // Example age, in a real scenario this would be fetched from a database or other source
        return age; // Assuming a fixed age for simplicity
    }

    static string getStudentNameById(int id)
    {
        string studentName = "Varun";
        int Id = 10;// Example name, in a real scenario this would be fetched from a database or other source
        Console.WriteLine($"Id is {Id} and Name is {studentName}");
        return studentName; 
    }
}