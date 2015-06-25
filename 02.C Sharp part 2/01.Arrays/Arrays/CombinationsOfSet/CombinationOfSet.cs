using System;

class Program
{

    static int[] result;
    static int k;
    static int n;

    static void Main()
    {
        Console.Write("Enter n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        k = int.Parse(Console.ReadLine());

        result = new int[k];

        Combine(0, 1);
    }

    static void Combine(int index, int startValue)
    {
        if (index == k)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0,3}", result[i]);
            }
            Console.WriteLine();
            return;
        }

        for (int i = startValue; i <= n; i++)
        {
            result[index] = i;
            Combine(index + 1, i + 1);
        }
    }
}
