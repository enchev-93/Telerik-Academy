using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        decimal fullPies = 0;

        decimal denominatior = 0;
        decimal nominator = 0;

        if (a >= 1 && b >= 1 && c >= 1 && d >= 1 && 
            a <= 999999 && b <= 999999 && c <= 999999 & d <= 999999)
        {
            denominatior = b * d;
            nominator = a * d + c * b;

            fullPies = nominator / denominatior;
        }

        if (fullPies >= 1)
        {
            Console.WriteLine("{0}\n{1}/{2}", (int)fullPies, nominator, denominatior);
        }
        else
        {
            Console.WriteLine("{0:F22}\n{1}/{2}", fullPies, nominator, denominatior);
        }
    }
}
