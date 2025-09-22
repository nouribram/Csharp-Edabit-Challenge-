// Problem: Convert Number to Corresponding Month Name
// ----------------------------------------------------
// Task:
//   Create a function that takes a number (1–12) and
//   returns the name of the corresponding month.
// Example:
//   MonthName(1) ➞ "January"
//   MonthName(12) ➞ "December"

using System;

class Program
{
    // Function to convert number to month name
    static string MonthName(int num)
    {
        // Array of month names where index 0 = January, ..., index 11 = December
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };

        // Subtract 1 because arrays are 0-indexed
        return months[num - 1];
    }

    static void Main(string[] args)
    {
        // Testing the function with sample inputs
        Console.WriteLine(MonthName(1));   // ➞ "January"
        Console.WriteLine(MonthName(12));  // ➞ "December"
    }
}
