using System;

/**
 Find the Smallest and Biggest Numbers
 Problem:
 Create a function that takes an array of numbers and returns
 both the minimum and maximum numbers, in that order.
 
 Examples:
 FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]
 FindMinMax([2334454, 5]) ➞ [5, 2334454]
 FindMinMax([1]) ➞ [1, 1]
 */

public class Program
{
   
    public static double[] FindMinMax(double[] arr)
    {
        // Initialize both min and max with the first element
        double min = arr[0];
        double max = arr[0];

        // Loop through the rest of the array
        for (int i = 1; i < arr.Length; i++)
        {
            // Update min if a smaller value is found
            if (arr[i] < min)
                min = arr[i];

            // Update max if a larger value is found
            if (arr[i] > max)
                max = arr[i];
        }

        // Return the results as a new array [min, max]
        return new double[] { min, max };
    }

  
}
