using System;

namespace school_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.");
            Console.WriteLine("Please enter Test Data:");
            var EnteredText = Console.ReadLine();
            if (EnteredText.Length > 0)
            {
                Console.WriteLine("Output: " + EnteredText[0] + EnteredText + EnteredText[0]);
            }
            else
            {
                Console.WriteLine("Entered text is less than 1 symbol!");
            }
            
        }
    }
}
