using System;
using System.Linq;

class DivisibleBy7And3
{
    /// <summary>
    /// Write a program that prints from given array of integers all 
    /// numbers that are divisible by 7 and 3. Use the built-in extension 
    /// methods and lambda expressions. Rewrite the same with LINQ.
    /// </summary>
    static void Main()
    {
        int[] numbers = Enumerable.Range(0, 700).ToArray();

        var sortedNumbers = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
        Console.WriteLine(string.Join("\t", sortedNumbers));
        Console.WriteLine();

        sortedNumbers =
            from number in numbers
            where number % 3 == 0 && number % 7 == 0
            select number;
        Console.WriteLine(string.Join("\t", sortedNumbers));
    }
}
