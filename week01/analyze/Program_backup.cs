using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        foreach (int n in new int[] { 1000, 10000, 100000, 1000000 })
        {
            List<int> data = new List<int>();
            for (int i = 0; i < n; i++) data.Add(i * 2); // sorted list

            int target = -1; // not in list = worst case

            int count1 = 0, count2 = 0;
            double time1 = 0, time2 = 0;

            for (int i = 0; i < 100; i++)
            {
                var sw1 = Stopwatch.StartNew();
                Search.SearchSorted1(data, target, out count1);
                sw1.Stop();
                time1 += sw1.Elapsed.TotalMilliseconds;

                var sw2 = Stopwatch.StartNew();
                Search.SearchSorted2(data, target, out count2);
                sw2.Stop();
                time2 += sw2.Elapsed.TotalMilliseconds;
            }

            Console.WriteLine($"n = {n}\tSort1 Count = {count1}, Time = {time1 / 100:F4}ms\tSort2 Count = {count2}, Time = {time2 / 100:F4}ms");
        }
    }
}
