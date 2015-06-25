using System;

class Carpets
{
    static void Main()
    {
        int n =  int.Parse(Console.ReadLine());

        int elementsOnLines = n;
        int center = elementsOnLines / 2;

        for (int i = 1; i <= n / 2; i++)
        {
            int elementPosition = 1;
            while (elementPosition <= elementsOnLines)
            {
                if ((elementPosition <= center - i) || (elementPosition > center + i))
                {
                    Console.Write('.');
                    elementPosition++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('/');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        elementPosition++;
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('\\');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        elementPosition++;
                    }
                }
            }
            Console.WriteLine();
        }


        for (int i = n / 2; i > 0; i--)
        {
            int elementPosition = 1;
            while (elementPosition <= elementsOnLines)
            {
                if ((elementPosition <= center - i) || (elementPosition > center + i))
                {
                    Console.Write('.');
                    elementPosition++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write('\\');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        elementPosition++;
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('/');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                        elementPosition++;
                    }
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
