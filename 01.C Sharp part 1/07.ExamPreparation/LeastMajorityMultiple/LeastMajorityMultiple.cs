using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int commonDiviser = 1;

        for (int i = 2; i < int.MaxValue; i++)
        {
            if (i % a == 0 && i % b == 0 && i % c == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % a == 0 && i % b == 0 && i % d == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % a == 0 && i % b == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % a == 0 && i % c == 0 && i % d == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % a == 0 && i % c == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % a == 0 && i % d == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % b == 0 && i % c == 0 && i % d == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % b == 0 && i % c == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % b == 0 && i % d == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
            else if (i % c == 0 && i % d == 0 && i % e == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
