// Problem: Convert Age to Days
// --------------------------------------
// Task:
//   Create a function that takes the age in years
//   and returns the age in days.
//
// Example:
//   AgeToDays(10) ➞ 3650
//   AgeToDays(20) ➞ 7300


using System;

class Program
{
    // Function to convert age (in years) to days
    static int AgeToDays(int age)
    {
        // Multiply the given age by 365 (days in a year)
        return age * 365;
    }

    static void Main(string[] args)
    {
        // Testing the function with sample inputs
        Console.WriteLine(AgeToDays(10));  // ➞ 3650
        Console.WriteLine(AgeToDays(20));  // ➞ 7300
    
    }
}
