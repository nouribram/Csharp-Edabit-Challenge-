/*
    # Sum of Two Numbers in C#

    This program defines a method to return the sum of two numbers.

    ## Problem
    Create a method `Sum` that takes two integers `a` and `b`, and returns their sum.

    ## Example
    Sum(2, 3)  // Output: 5
    Sum(-1, 4) // Output: 3
    Sum(0, 0)  // Output: 0

    ## How It Works
    - The method `Sum` takes two integer parameters.
    - It adds them together using the `+` operator.
    - The result is returned as an integer.
*/

using System;

public class Program
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    // Optional Main method to test the function
    public static void Main()
    {
        Console.WriteLine(Sum(5, 10)); // Output: 15
    }
}
