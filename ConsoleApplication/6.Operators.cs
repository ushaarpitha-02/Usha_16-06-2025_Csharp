using System;
class Operators
{
    static void Main()
    {
        // Arithmetic Operators
        // + : Adds two operands. Example: 5 + 3 results in 8.
        // - : Subtracts the second operand from the first. Example: 10 - 4 results in 6.
        // * : Multiplies two operands. Example: 3 * 4 results in 12.
        // / : Divides the first operand by the second. Example: 10.0 / 3.0 results in approximately 3.3333.
        // % : Returns the remainder of a division operation. Example: 10 % 3 results in 1.

        // Comparison Operators it return the boolean
        // == : Checks if two operands are equal. Example: 5 == 5 results in true.
        // != : Checks if two operands are not equal. Example: 5 != 3 results in true.
        // > : Checks if the first operand is greater than the second. Example: 8 > 5 results in true.
        // < : Checks if the first operand is less than the second. Example: 3 < 7 results in true.
        // >= : Checks if the first operand is greater than or equal to the second. Example: 8 >= 8 results in true.
        // <= : Checks if the first operand is less than or equal to the second. Example: 3 <= 7 results in true.

        // Logical Operators
        // && : Returns true if both operands are true. Example: true && true results in true.
        // || : Returns true if at least one of the operands is true. Example: true || false results in true.
        // ! : Inverts the boolean value. Example: !true results in false.




        // Arithmetic Operators
        int a = 10, b = 20;
        Console.WriteLine("Addition: " + (a + b)); // 30
        Console.WriteLine("Subtraction: " + (a - b)); // -10
        Console.WriteLine("Multiplication: " + (a * b)); // 200
        Console.WriteLine("Division: " + (b / a)); // 2
        Console.WriteLine("Modulus: " + (b % a)); // 0
        // Comparison Operators
        Console.WriteLine("Equal: " + (a == b)); // False
        Console.WriteLine("Not Equal: " + (a != b)); // True
        Console.WriteLine("Greater Than: " + (a > b)); // False
        Console.WriteLine("Less Than: " + (a < b)); // True
        Console.WriteLine("Greater Than or Equal To: " + (a >= b)); // False
        Console.WriteLine("Less Than or Equal To: " + (a <= b)); // True
        // Logical Operators
        bool x = true, y = false;
        Console.WriteLine("Logical AND: " + (x && y)); // False
        Console.WriteLine("Logical OR: " + (x || y)); // True
        Console.WriteLine("Logical NOT: " + (!x)); // False
        // Assignment Operators
        int c = 5;
        c += 3; // c = c + 3
        Console.WriteLine("Assignment with Addition: " + c); // 8
        c -= 2; // c = c - 2
        Console.WriteLine("Assignment with Subtraction: " + c); // 6
        c *= 2; // c = c * 2
        Console.WriteLine("Assignment with Multiplication: " + c); // 12
        c /= 3; // c = c / 3
        Console.WriteLine("Assignment with Division: " + c); // 4
        c %= 3; // c = c % 3
        Console.WriteLine("Assignment with Modulus: " + c); // 1


        int sum = (9 + 10);
        double difference = (20 - 19.123);
        int product = (5 * 6);
        double quotient = (20 / 4);
        int remainder = (10 % 3);

        string output = string.Format("sum {0} difference {1} product {2} quotient {3} remainder {4} ", sum, difference, product, quotient, remainder);
        Console.Write(output);
        
        Console.WriteLine();

        bool isEqual = (5 == 5);
        bool isNotEqual = (5 != 3);
        bool isGreaterThan = (8 > 5);
        bool isLessThan = (3 < 7);
        bool isGreaterThanOrEqual = (8 >= 8);
        bool isLessThanOrEqual = (3 <= 7);
        string comparisonOutput=$"isEqual {isEqual} isNotEqual {isNotEqual} isGreaterThan {isGreaterThan} isLessThan {isLessThan} isGreaterThanOrEqual {isGreaterThanOrEqual} isLessThanOrEqual {isLessThanOrEqual}";
        Console.WriteLine(comparisonOutput);

        bool logicalAnd = (true && false);
        bool logicalOr = (true || false);
        bool logicalNot = !true;
        string logicalOutput = string.Format("logicalAnd {0} logicalOr {1} logicalNot {2}", logicalAnd, logicalOr, logicalNot);
        Console.WriteLine(logicalOutput);


        string name = "Usha Arpitha";
        int nameLength = 10;
        bool isNameLengthEqual = (name.Length == nameLength);
        Console.WriteLine(isNameLengthEqual);

        string[] currencyItems = new string[] { "10$", "20$", "30$" };
        int noOfCurrencyItems = 3;
        bool isCurrnceyNotesEqaual = (currencyItems.Length == noOfCurrencyItems);
        Console.WriteLine(isCurrnceyNotesEqaual);

        // Conditional Operator (Ternary Operator)
        int age = 18;
        string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";
        Console.WriteLine(eligibility); // Eligible to vote
        // Null Coalescing Operator
        string nameInput = null;
        string displayName = nameInput ?? "Default Name";
        Console.WriteLine(displayName); // Default Name
        // Bitwise Operators
        int x1 = 5; // 0101 in binary
        int y1 = 3; // 0011 in binary
        Console.WriteLine("Bitwise AND: " + (x1 & y1)); // 1 (0001 in binary)
        Console.WriteLine("Bitwise OR: " + (x1 | y1)); // 7 (0111 in binary)
        Console.WriteLine("Bitwise XOR: " + (x1 ^ y1)); // 6 (0110 in binary)
        Console.WriteLine("Bitwise NOT: " + (~x1)); // -6 (inverts bits, 1010 in binary for 5)
        // Shift Operators
        int z = 8; // 1000 in binary
        Console.WriteLine("Left Shift: " + (z << 2)); // 32 (00100000 in binary)
        Console.WriteLine("Right Shift: " + (z >> 2)); // 2 (0010 in binary)
        // Type Operators
        object obj = "Hello, World!";
        bool isString = obj is string; // Checks if obj is of type string
        Console.WriteLine("Is obj a string? " + isString); // True
       
        // Sizeof Operator
        Console.WriteLine("Size of int: " + sizeof(int)); // 4 bytes
        Console.WriteLine("Size of double: " + sizeof(double)); // 8 bytes
       


    }


}