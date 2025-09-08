/*
========================================
 Problem: Convert Minutes to Seconds 
========================================
Create a function that takes an integer `minutes` 
and converts it into seconds.

Example:
Input: 5
Output: 300

----------------------------------------
 Explanation
----------------------------------------
- 1 minute = 60 seconds.
- Multiply the input `minutes` by 60.
- Return the result as an integer.
*/

using System;

public class Program
{
    // Function that converts minutes to seconds
    public static int Convert(int minutes)
    {
        return minutes * 60;
    }

    static void Main()
    {
        // Testing the function with sample inputs
        Console.WriteLine(Convert(5));   // Output: 300
        Console.WriteLine(Convert(10));  // Output: 600
        Console.WriteLine(Convert(0));   // Output: 0
    }
}
