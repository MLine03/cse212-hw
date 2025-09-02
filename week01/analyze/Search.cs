using System;
using System.Collections.Generic;

public class Search
{
    // Linear Search - O(n)
    public static int SearchSorted1(List<int> list, int target, out int count)
    {
        count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            count++;
            if (list[i] == target)
                return i;
        }
        return -1;
    }

    // Binary Search - O(log n)
    public static int SearchSorted2(List<int> list, int target, out int count)
    {
        count = 0;
        int low = 0;
        int high = list.Count - 1;

        while (low <= high)
        {
            count++;
            int mid = (low + high) / 2;
            if (list[mid] == target)
                return mid;
            else if (list[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}
