// -------------------------------------------------------------
// Problem: Return the Next Number from the Integer Passed
// -------------------------------------------------------------
// Create a function that takes a number as an argument,
// increments the number by +1 and returns the result.
//
// Example:
// Input: 4   → Output: 5
// Input: -1  → Output: 0
//
// Explanation:
// 1. The function accepts one integer as input.
// 2. It simply adds 1 to the given integer.
// 3. The result is returned.
// -------------------------------------------------------------

using System;

public class Program
{
    // Function to return the next number
    public static int NextNumber(int num)
    {
        return num + 1;  // Increment by 1
    }

    public static void Main(string[] args)
    {
        // Testing the function with different values
        Console.WriteLine(NextNumber(-1));   // Output: 0
        Console.WriteLine(NextNumber(99));   // Output: 100
    }
}
