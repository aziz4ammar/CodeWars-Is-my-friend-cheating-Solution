using System;
using System.Collections.Generic;

public class RemovedNumbers
{
    public static List<long[]> removNb(long n)
    {
        List<long[]> result = new List<long[]>();
        long sum = n * (n + 1) / 2; // Sum of integers from 1 to n

        for (long a = 1; a <= n; a++)
        {
            long b = (sum - a) / (a + 1);
            
            if (a * b + a + b == sum && b <= n && a != b)
            {
                result.Add(new long[] { a, b });
            }
        }

        return result;
    }
}
