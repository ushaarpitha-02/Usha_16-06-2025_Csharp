using System;

class Methodswithparametersandreturntypes
{
    static void Main()
    {
        string Employeename = EmployeeName();
        Console.WriteLine("Employee Name is: " + Employeename);

        Console.WriteLine("Enter Employee ID:");
        int id = Convert.ToInt32(Console.ReadLine());
        DisplayEmployeeDetails(id);

        int name = getstudentdetails("Usha");
        Console.WriteLine("Student ID: " + id + ", Name: " + name);

        int age1 = getstudentage(25);
        Console.WriteLine("Student Age: " + age1);


        string[] names = getnames(25);
        foreach (string name1 in names)
        {
            Console.WriteLine(name1);
        }

        string[] fruits = { "Apple", "Banana", "Cherry", "Dragonfruit", "Elderberry" };
        int fruitCount = getfruitssbynumber(fruits);
        Console.WriteLine("Number of fruits with more than 5 characters: " + fruitCount);



    }
    static string EmployeeName()
    {
        string Name = "Usha Arpitha";
        return Name;
    }
    //getting details with the employee id using parameters in method with using return type
    static string EmployeeDetails(int id)
    {
        if (id == 1)
        {
            return "Employee ID: 1, Name: John Doe, Position: Software Engineer";
        }
        else if (id == 2)
        {
            return "Employee ID: 2, Name: Jane Smith, Position: Project Manager";
        }
        else
        {
            return "Employee not found.";
        }
    }
    static void DisplayEmployeeDetails(int id)
    {
        string details = EmployeeDetails(id);
        Console.WriteLine(details);
    }

    static int getstudentdetails(string name)
    {
        int id = 0;

        return id;
    }

    static int getstudentage(int age)
    {
        return age;
    }

    static string[] getnames( int age)
    {
        string[] names = { "Usha", "Arpitha", "Vinitha", "Vinni" };
        return names;


    }

    static int getfruitssbynumber(string[] fruits)
    {
       
        int count = 0;
        foreach (string fruit in fruits)
        {
            if (fruit.Length > 5)
            {
                count++;
            }
        }
        return count;
    }
    

}

