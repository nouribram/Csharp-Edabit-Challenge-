//  Absolute Sum 
// --------------------------------------------------
// Explanation:
// - check every element at least once (O(n) time).
// - Use Math.Abs() to convert negative numbers to positive.
// - Accumulate the sum in a single pass.
// --------------------------------------------------


using System;

public class Program
{
    public static int GetAbsSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += Math.Abs(num);
        }
        return sum;
    }
}
