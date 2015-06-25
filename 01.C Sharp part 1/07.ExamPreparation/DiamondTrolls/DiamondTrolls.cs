using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DiamondTrolls
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int height = 6 + ((N - 3) / 2) * 3;
        int width = N * 2 + 1;

        int topDots = (width - N) / 2;

        Console.Write(new string('.', topDots));
        Console.Write(new string('*', N));
        Console.Write(new string('.', topDots));
        Console.WriteLine();

        int nextDots = topDots - 1;
        int topRows = topDots;
        for (int i = 0; i < topRows - 1; i++)
        {
            topDots--;
            Console.Write(new string('.', topDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', topDots));
            Console.WriteLine();

            nextDots++;
        }
        Console.WriteLine(new string('*', width));

        int firstDots = 1;
        for (int i = 0; i < N - 1; i++)
        {
            nextDots--;
            Console.Write(new string('.', firstDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', firstDots));
            Console.WriteLine();

            firstDots++;
            
        }

        Console.Write(new string('.', N));
        Console.Write('*');
        Console.Write(new string('.', N));
        Console.WriteLine();
    }
}
