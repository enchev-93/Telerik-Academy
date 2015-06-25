using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        Console.Write(new string('.', n));
        Console.Write(new string('*', n));
        Console.WriteLine();

        int outDots = n - 1;
        int inDots = n - 1;

        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', outDots));
            Console.Write('*');
            Console.Write(new string('.', inDots));
            Console.Write('*');
            Console.WriteLine();
            outDots--;
            inDots++;
        }
        Console.WriteLine(new string('*', n * 2));
    }
}
