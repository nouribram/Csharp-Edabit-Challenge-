//  Absolute Sum 
// --------------------------------------------------
// Explanation:
// - check every element at least once (O(n) time).
// - Use Math.Abs() to convert negative numbers to positive.
// - Accumulate the sum in a single pass.
// --------------------------------------------------

using System;

public class AbsoluteSumChallenge
{
    public static int AbsoluteSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
            sum += Math.Abs(num);
        return sum;
    }

    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(AbsoluteSum(new int[] { -3, -4, -10, 0 })); // 17
        Console.WriteLine(AbsoluteSum(new int[] { }));                // 0
    }
}
