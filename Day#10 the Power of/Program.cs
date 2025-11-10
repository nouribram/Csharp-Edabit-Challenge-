/* Challenge: "To the Power of _____" (Edabit)
Create a function that takes a base number and an exponent number
and returns the calculation (base ^ exponent).
Compatible with Edabit compiler (expects long return type).*/

using System;

public class Program
{
    // Uses Math.Pow() and casts the result to long

    public static long CalculateExponent(long number, long exponent)
    {
        return (long)Math.Pow(number, exponent);
    }

    // Example test cases (for local testing)
    public static void Main()
    {
        Console.WriteLine("=== To the Power of _____ ===\n");
        Console.WriteLine($"3 ^ 4 = {CalculateExponent(3, 4)}");   // 81
    }
}
