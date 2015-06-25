using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    /// <summary>
    /// Implement a set of extension methods for IEnumerable<T> that
    /// implement the following group functions: sum, product, min, max,average.
    /// </summary>
    static void Main()
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Sum of elements: {0}", list.Sum());
        Console.WriteLine("Average of elements: {0:F2}", list.Average());
        Console.WriteLine("Product of elements: {0}", list.Product());
        Console.WriteLine("Minimal element: {0}", list.Min());
        Console.WriteLine("Maximal element: {0}", list.Max());
    }

    public static dynamic Sum<T>(this IEnumerable<T> items)
    {
        dynamic sum = default(T);
        foreach (var item in items)
        {
            sum += item;
        }

        return sum;
    }

    public static dynamic Average<T>(this IEnumerable<T> items)
    {
        dynamic sum = default(T);
        double count = 0;
        foreach (var item in items)
        {
            sum += item;
            count++;
        }

        return sum / count;
    }

    public static dynamic Product<T>(this IEnumerable<T> items)
    {
        dynamic product = 1;
        foreach (var item in items)
        {
            product *= item;
        }

        return product;
    }

    public static dynamic Min<T>(this IEnumerable<T> items) where T : IComparable<T>
    {
        var enumerable = items as IList<T> ?? items.ToList();
        var enumerator = enumerable.GetEnumerator();
        enumerator.MoveNext();
        T currentElement = enumerator.Current;
        foreach (var item in enumerable)
        {
            if ((dynamic)item < currentElement)
            {
                currentElement = item;
            }
        }

        return currentElement;
    }

    public static dynamic Max<T>(this IEnumerable<T> items)
    {
        var collection = items as IList<T> ?? items.ToList();
        var enumerator = collection.GetEnumerator();
        enumerator.MoveNext();
        T currentElement = enumerator.Current;
        foreach (var item in collection)
        {
            if ((dynamic)item > currentElement)
            {
                currentElement = item;
            }
        }

        return currentElement;
    }
}
