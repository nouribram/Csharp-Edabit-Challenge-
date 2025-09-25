/*
    Hamming Distance Problem 
    ---------------------------------
    Problem Definition:
    The Hamming distance between two strings of equal length is 
    the number of positions where the characters are different.

    Example:
    Input: "abcde", "bcdef"
    Step-by-step:
        a vs b → different
        b vs c → different
        c vs d → different
        d vs e → different
        e vs f → different
    Output: 5

    ---------------------------------
    Solution Approach:
    1. Check that both strings have equal length.
    2. Use a loop to compare characters at the same index.
    3. Keep a counter for differences.
    4. Return the counter as the Hamming distance.
*/

using System;

public class Program
{
    public static int HammingDistance(string str1, string str2)
    {
        // Validate input: Hamming distance only works on equal length strings
        if (str1.Length != str2.Length)
            throw new ArgumentException("Strings must be of equal length");

        int distance = 0;

        // Compare each character position
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                distance++; // Increment if characters differ
            }
        }

        return distance;
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(HammingDistance("abcde", "bcdef"));   // Output: 5
        Console.WriteLine(HammingDistance("strong", "strung")); // Output: 1
        Console.WriteLine(HammingDistance("10101", "11110"));   // Output: 3
    }
}
