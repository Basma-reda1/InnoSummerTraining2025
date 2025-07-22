using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n;

        // Input validation
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        Console.WriteLine("\n--- Method 1: Using Loop ---");
        Stopwatch stopwatch1 = Stopwatch.StartNew();

        int sum1 = 0;
        for (int i = 1; i <= n; i++)
        {
            sum1 += i;
        }

        stopwatch1.Stop();
        Console.WriteLine($"Sum (loop method): {sum1}");
        Console.WriteLine($"Time taken: {stopwatch1.Elapsed.TotalMilliseconds} ms");

        Console.WriteLine("\n--- Method 2: Using Formula ---");
        Stopwatch stopwatch2 = Stopwatch.StartNew();

        int sum2 = n * (n + 1) / 2;

        stopwatch2.Stop();
        Console.WriteLine($"Sum (formula method): {sum2}");
        Console.WriteLine($"Time taken: {stopwatch2.Elapsed.TotalMilliseconds} ms");

        // Comparison
        Console.WriteLine("\n--- Comparison ---");
        if (sum1 == sum2)
        {
            Console.WriteLine("Both methods returned the same result.");
        }
        else
        {
            Console.WriteLine("The methods returned different results!");
        }
    }
}






