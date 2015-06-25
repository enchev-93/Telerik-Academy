using System;

class TribonacciTriangle
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d;


        int l = int.Parse(Console.ReadLine());
        for (int row = 1; row <= l; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                for (int i = 0; i < l - (l -1); i++)
                {
                    Console.Write("{0} ", a);
                    d = a + b + c;
                    a = b;
                    b = c;
                    c = d;
                }
            }
            Console.WriteLine();
        }
    }
}
