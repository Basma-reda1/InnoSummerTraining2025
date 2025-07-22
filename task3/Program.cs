using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        Console.WriteLine("\n--- Method 1: Using string concatenation ---");
        Stopwatch sw1 = Stopwatch.StartNew();
        string result1 = "";
        for (int i = 1; i <= n; i++)
        {
            result1 += i;
            if (i != n)
                result1 += ", ";
        }
        sw1.Stop();
        Console.WriteLine(result1);
        Console.WriteLine($"Time taken: {sw1.ElapsedMilliseconds} ms");

        Console.WriteLine("\n--- Method 2: Using StringBuilder ---");
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            sb.Append(i);
            if (i != n)
                sb.Append(", ");
        }
        string result2 = sb.ToString();
        sw2.Stop();
        Console.WriteLine(result2);
        Console.WriteLine($"Time taken: {sw2.ElapsedMilliseconds} ms");
    }
}

