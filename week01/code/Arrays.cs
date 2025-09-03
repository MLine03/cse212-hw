using System;
using System.Collections.Generic;

public static class Arrays
{
    // Part 1: MultiplesOf function
    // Creates and returns an array of multiples of a given starting number.
    public static double[] MultiplesOf(double start, int count)
    {
        // Create an array to hold the multiples
        double[] multiples = new double[count];

        // Loop through to calculate each multiple
        for (int i = 0; i < count; i++)
        {
            // Calculate the multiple and assign to the array
            multiples[i] = start * (i + 1);
        }

        // Return the array of multiples
        return multiples;
    }

    // Part 2: RotateListRight function
    // Rotates the input list to the right by the specified amount.
    public static void RotateListRight(List<int> data, int amount)
    {
        // Get the last 'amount' elements to move to the front
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Get the remaining elements from the start to before the rotation point
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Clear the original list to prepare for rearrangement
        data.Clear();

        // Add the right part first
        data.AddRange(rightPart);

        // Add the left part next
        data.AddRange(leftPart);
    }
}
