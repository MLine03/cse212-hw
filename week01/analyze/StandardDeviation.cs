using System;
using System.Collections.Generic;
using System.Linq;

public class StandardDeviation
{
    // Method 1: Two-pass calculation
    public static double StdDev1(List<double> data)
    {
        double mean = data.Average();
        double sumSquares = 0;

        foreach (double x in data)
            sumSquares += (x - mean) * (x - mean);

        return Math.Sqrt(sumSquares / data.Count);
    }

    // Method 2: One-pass calculation
    public static double StdDev2(List<double> data)
    {
        double mean = 0;
        double sumSquares = 0;
        int n = 0;

        foreach (double x in data)
        {
            n++;
            double delta = x - mean;
            mean += delta / n;
            sumSquares += delta * (x - mean);
        }

        return Math.Sqrt(sumSquares / n);
    }

    // Method 3: Using LINQ
    public static double StdDev3(List<double> data)
    {
        double mean = data.Average();
        double variance = data.Sum(x => (x - mean) * (x - mean)) / data.Count;
        return Math.Sqrt(variance);
    }
}
