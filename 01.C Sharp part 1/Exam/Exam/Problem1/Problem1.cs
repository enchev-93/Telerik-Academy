using System;

class Problem1
{
    static void Main()
    {
        double a = long.Parse(Console.ReadLine());
        double b = long.Parse(Console.ReadLine());
        double c = long.Parse(Console.ReadLine());

        double arithmeticMean = 0;

        // gives max
        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (b >= a & b >= c)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine(c);
        }
        // gives min
        if (a <= b && a <= c)
        {
            Console.WriteLine(a);
        }
        else if (b <= a && b <= c)
        {
            Console.WriteLine(b);
        }
        else if (c <= a && c <= b)
        {
            Console.WriteLine(c);
        }

        // gives arithmetic mean

        arithmeticMean += (a + b + c) / 3;
        Console.WriteLine("{0:F3}", arithmeticMean);
    }
}
