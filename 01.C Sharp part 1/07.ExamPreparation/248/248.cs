using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long r = 0;
        if (a > 1 && b > 1 && c > 1 && a < 999999 && b < 999999 && c < 999999)
        {
            if (b == 2)
            {
                r = a % c;
            }
            else if (b == 4)
            {
                r = a + c;
            }
            else if (b == 8)
            {
                r = a * c;
            }

            long rr = 0;
            if (r % 4 == 0)
            {
                rr = r / 4;
            }
            else
            {
                rr = r % 4;
            }
            Console.WriteLine(rr);
            Console.WriteLine(r);
        }
    }
}
