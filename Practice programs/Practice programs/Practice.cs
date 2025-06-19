using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a string to find duplicate characters: ");
        string name = Console.ReadLine();

        for (int i = 0; i < name.Length; i++)
        {
            char currentposition = name[i];
            int countvalue = 0;


            for (int j = 0; j < name.Length; j++)
            {
                if (name[j] == currentposition)
                {
                    countvalue++;
                }
            }


            if (countvalue > 1 && name.IndexOf(currentposition) == i)
            {
                Console.WriteLine(currentposition);
            }
        }
    }

}
