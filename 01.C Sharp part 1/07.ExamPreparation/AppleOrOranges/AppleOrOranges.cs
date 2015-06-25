using System;

class AppleOrOranges
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        int odd = 0;
        int even = 0;

        if (n < 0)
        {
            n *= -1;
        }

        while (n != 0)
        {
            int digit = (int)(n % 10);
            n /= 10;

            if (digit % 2 == 0)
            {
                even += digit;
            }
            else
            {
                odd += digit;
            }
        }

        if (odd > even)
        {
            Console.WriteLine("left {0}", odd);
        }
        else if (even > odd)
        {
            Console.WriteLine("right {0}", even);
        }
        else if (even == odd)
        {
            Console.WriteLine("straight {0}", even);
        }
    }
}
