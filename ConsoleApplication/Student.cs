using System;
class StudentReport
{
    static void Main()
    {
        Console.WriteLine("Enter the student's name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Student's Roll Number:");
        int rollNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in Mathematics:");
        int mathMarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in Science:");
        int scienceMarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in English:");
        int englishMarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in History:");
        int historyMarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in Geography:");
        int geographyMarks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Student's Marks in Computer Science:");
        int computerScienceMarks = Convert.ToInt32(Console.ReadLine());

        if (mathMarks < 0 || scienceMarks < 0 || englishMarks < 0 ||
           historyMarks < 0 || geographyMarks < 0 || computerScienceMarks < 0
           &&
           mathMarks > 100 || scienceMarks > 100 || englishMarks > 100 ||
           historyMarks > 100 || geographyMarks > 100 || computerScienceMarks > 100)
        {
            Console.WriteLine("Error: Marks should be between 0 and 100.");
            return;//what is the use of return here
            // It exits the Main method if any marks are negative.
        }
        int totalMarks = mathMarks + scienceMarks + englishMarks + historyMarks + geographyMarks + computerScienceMarks;
        double averageMarks = totalMarks / 6.0; // Use 6.0 to ensure double division
        string grade;
        if (averageMarks >= 90)
        {
            grade = "A+";
        }
        else if (averageMarks >= 80)
        {
            grade = "A";
        }
        else if (averageMarks >= 70)
        {
            grade = "B+";
        }
        else if (averageMarks >= 60)
        {
            grade = "B";
        }
        else if (averageMarks >= 50)
        {
            grade = "C";
        }
        else if (averageMarks >= 40)
        {
            grade = "D";
        }
        else
        {
            grade = "Fail";
        }
        //Console.Clear();

        Console.WriteLine("\nStudent Report Card");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll Number: {rollNumber}");
        //Console.WriteLine($"Marks in Mathematics: {mathMarks}");
        //Console.WriteLine($"Marks in Science: {scienceMarks}");
        //Console.WriteLine($"Marks in English: {englishMarks}");
        //Console.WriteLine($"Marks in History: {historyMarks}");
        //Console.WriteLine($"Marks in Geography: {geographyMarks}");
        //Console.WriteLine($"Marks in Computer Science: {computerScienceMarks}");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks:F2}"); // Display average with 2 decimal places
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine("---------------------");
        Console.Write("Do you want to enter another student? (yes/no): ");
        string continueInput = Console.ReadLine().ToLower();
        continueInput = Console.ReadLine().ToLower();

     while (continueInput == "yes" || continueInput == "y");
        {
            Main(); // Recursively call Main to re-enter student data
            Console.WriteLine("\nThank you for using the Student Grade Processing System!");

        }







    }


}


