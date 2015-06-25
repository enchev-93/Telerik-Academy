using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] sheetsValue = new int[11]
            {
                1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1
            };

        for (int i = 0; i < sheetsValue.Length; i++)
        {
            if (n < sheetsValue[i])
            {
                Console.WriteLine("A" + i);
            }
            else
            {
                n -= sheetsValue[i];
            }
        }







        //for (int i = 0; i < 11; i++)
        //{
        //    int bitToTake = i;
        //    int mask = 1 << bitToTake;
        //    int numberAndMask = n & mask;
        //    int bashSiBit = numberAndMask >> bitToTake;

        //    if (bashSiBit == 0)
        //    {
        //        Console.WriteLine("A" + (10 - i));
        //    }
        //}
    }
}