using System;

class Problem4
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int height = (2 * n) + 1;
        int width = (2 * n) + 1;

        for (int i = 0; i < width; i++)
        {
            if (d > width)
            {
                Console.Write(new string('#', width));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('#', d));
                Console.Write('\\');
                Console.Write(new string('.', (height - 2) - (d * 2)));
                Console.Write('/');
                Console.Write(new string('#', d));
                Console.WriteLine();
                ;

                    

            }
        }
    }
}
