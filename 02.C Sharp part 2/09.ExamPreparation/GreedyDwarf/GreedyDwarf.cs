using System;

class GreedyDwarf
{
    static void Main()
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        long[] valleyNuber = new long[rawNumbers.Length];

        for (int i = 0; i < valleyNuber.Length; i++)
        {
            valleyNuber[i] = int.Parse(rawNumbers[i]);
        }

        int numberOfPatterns = int.Parse(Console.ReadLine());
        long bestSum = int.MinValue;

        for (int i = 0; i < numberOfPatterns; i++)
        {
            long sum = ProccessPattern(valleyNuber);

            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }

        Console.WriteLine(bestSum);
    }

    static long ProccessPattern(long[] valley)
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[rawNumbers.Length];

        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(rawNumbers[i]);
        }

        bool[] visited = new bool[valley.Length];
        long coinsSum = 0;
        coinsSum += valley[0];
        visited[0] = true;
        int currentPosition = 0;

        while (true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                int nextMove = currentPosition + pattern[i];

                if (nextMove >= 0
                    && nextMove < valley.Length
                    && !visited[nextMove])
                {
                    coinsSum += valley[nextMove];
                    visited[nextMove] = true;
                    currentPosition = nextMove;
                }
                else
                {
                    return coinsSum;
                }
            }
        }

        return 0;
    }
}