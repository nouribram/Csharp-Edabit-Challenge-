/*
 Circuit Power Calculator
=======================================
 Problem Explanation
 Formula:
    P = V × I

 Where:
   P = Power (Watts, W)
   V = Voltage (Volts, V)
   I = Current (Amperes, A)

 Examples:
   CircuitPower(230, 10) ➞ 2300
   CircuitPower(110, 3)  ➞ 330
   CircuitPower(480, 20) ➞ 9600
*/

using System;

class Program
{
    // Function to calculate circuit power
    static int CircuitPower(int voltage, int current)
    {
        // Power = Voltage × Current
        return voltage * current;
    }

    static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(CircuitPower(230, 10));  // Output: 2300
    }
}
