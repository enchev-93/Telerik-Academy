using System;

class EasterMister
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = 2 * n;
        int width = 3 * n + 1;

        for (int r = 0; r < height; r++)
        {
            for (int c = 0; c < width; c++)
            {
                if ((c > n  && c < 2 * n) && (r == 0 || r == height - 1))
                {
                    Console.Write('*');
                }
                else if ((r >= n / 2 && r < 2 * n - n / 2) && (c == 1 || c == width - 2))
                {
                    Console.Write('*');
                }
                else if (2 * r - c == -(2 * n - 1) || 2 * r - c == 3 * n - 3)
                {
                    Console.Write('*');
                }
                else if (2 * r + c == n + 1 || 2 * r + c == 6 * n - 3)
                {
                    Console.Write('*');
                }
                else if ((r == n || r == n - 1) && (c > 1 && c < width - 2) && (r + c) % 2 == 1)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
//int n = int.Parse(Console.ReadLine());

//int height = 2 * n;
//int widthEgg = 3 * n - 1;
//int widthDrawing = 3 * n + 1;

//int topDots = n + 1;
//int middleDots = n + 1;

//Console.Write(new string('.', topDots));
//Console.Write(new string('*', n - 1));
//Console.Write(new string('.', topDots));
//Console.WriteLine();

//for (int i = 0; i <= topDots - 1; i++)
//{
//    topDots -= 2;
//    Console.Write(new string('.', topDots));
//    Console.Write('*');
//    Console.Write(new string ('.', middleDots));
//    Console.Write('*');
//    Console.Write(new string('.', topDots));
//    Console.WriteLine();
//    middleDots += 4;
//}


//for (int i = 0; i <= (n - 1) / 2; i++)
//{
//    middleDots -= 4;
//    Console.Write(new string('.', topDots));
//    Console.Write('*');
//    Console.Write(new string('.', middleDots));
//    Console.Write('*');
//    Console.Write(new string('.', topDots));
//    Console.WriteLine();
//    topDots += 2;

//}


////Console.Write(new string('.', n + 1));
////Console.Write(new string('*', n - 1));
////Console.Write(new string('.', n + 1));
//Console.WriteLine();