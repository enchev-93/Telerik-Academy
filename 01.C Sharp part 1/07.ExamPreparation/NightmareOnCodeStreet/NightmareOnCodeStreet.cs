using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int sum = 0;
        int count = 0;
        int even = 0;

        foreach (char number in text)
        {
            if (count % 2 != 0)
            {
                if (char.IsDigit(number))
                {
                    even++;
                    sum += number - '0';
                }
            }
            count++;
        }
        Console.Write(even + " " + sum);
        Console.WriteLine();
    }
}
