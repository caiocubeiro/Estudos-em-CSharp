using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
        Debug.WriteLine($"We are looking for the {n}th number");
        foreach (var i in Fibonacci().Take(20))
        {
            Console.WriteLine(i);
        }
            int sum;
            int n1;
            int n2;
        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
        }


    }

    private static IEnumerable<int> Fibonacci()
    {
        int current = 1, next = 1;

        while (true)
        {
            yield return current;
            next = current + (current = next);
        }
    }
}
