using System;

class BullsAndCows
{
    static void Main()
    {
        int guessNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool foundNumber = false;

        for (int i = 1000; i <= 9999; i++)
        {
            int currentBulls = 0;
            int currentCows = 0;

            int currentNumber = i;
            int currentD = currentNumber % 10;
            currentNumber /= 10;
            int currentC = currentNumber % 10;
            currentNumber /= 10;
            int currentB = currentNumber % 10;
            currentNumber /= 10;
            int currentA = currentNumber % 10;

            if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)
            {
                continue;
            }

            int tempGuessNumber = guessNumber;
            int guessNumberD = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberC = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberB = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberA = tempGuessNumber % 10;

            # region Find bulls
            if (currentA == guessNumberA)
            {
                currentBulls++;
                currentA = -1;
                guessNumberA = -2;
            }
            if (currentB == guessNumberB)
            {
                currentBulls++;
                currentB = -1;
                guessNumberB = -2;
            }
            if (currentC == guessNumberC)
            {
                currentBulls++;
                currentC = -1;
                guessNumberC = -2;
            }
            if (currentD == guessNumberD)
            {
                currentBulls++;
                currentD = -1;
                guessNumberD = -2;
            }
            # endregion
            # region ABCD
            if (currentA == guessNumberB)
            {
                currentCows++;
                currentA = -1;
                guessNumberB = -2;
            }

            if (currentA == guessNumberC)
            {
                currentCows++;
                currentA = -1;
                guessNumberC = -2;
            }

            if (currentA == guessNumberD)
            {
                currentCows++;
                currentA = -1;
                guessNumberD = -2;
            }
            # endregion
            # region BACD
            if (currentB == guessNumberA)
            {
                currentCows++;
                currentB = -1;
                guessNumberA = -2;
            }

            if (currentB == guessNumberC)
            {
                currentCows++;
                currentB = -1;
                guessNumberC = -2;
            }

            if (currentB == guessNumberD)
            {
                currentCows++;
                currentB = -1;
                guessNumberD = -2;
            }
            # endregion
            # region CABD
            if (currentC == guessNumberA)
            {
                currentCows++;
                currentC = -1;
                guessNumberA = -2;
            }

            if (currentC == guessNumberB)
            {
                currentCows++;
                currentC = -1;
                guessNumberB = -2;
            }

            if (currentC == guessNumberD)
            {
                currentCows++;
                currentC = -1;
                guessNumberD = -2;
            }
            # endregion
            # region DABC
            if (currentD == guessNumberA)
            {
                currentCows++;
                currentD = -1;
                guessNumberA = -2;
            }

            if (currentD == guessNumberB)
            {
                currentCows++;
                currentD = -1;
                guessNumberB = -2;
            }

            if (currentD == guessNumberC)
            {
                currentCows++;
                currentD = -1;
                guessNumberC = -2;
            }
            # endregion

            if (currentBulls == bulls && currentCows == cows)
            {
                foundNumber = true;
                Console.Write("{0} ", i);
            }
        }
        if (!foundNumber)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
        


        //int guesNum = int.Parse(Console.ReadLine());
        //int targetBulls = int.Parse(Console.ReadLine());
        //int targetCows = int.Parse(Console.ReadLine());

        //bool solutionFound = false;

        //for (int d1 = 1; d1 <= 9; d1++)
        //{
        //    for (int d2 = 1; d2 <= 9; d2++)
        //    {
        //        for (int d3 = 1; d3 <= 9; d3++)
        //        {
        //            for (int d4 = 1; d4 <= 9; d4++)
        //            {
        //                int guess1 = (guesNum / 1000) % 10;
        //                int guess2 = (guesNum / 100) % 10;
        //                int guess3 = (guesNum / 10) % 10;
        //                int guess4 = (guesNum / 1) % 10;

        //                int oldD1 = d1;
        //                int oldD2 = d2;
        //                int oldD3 = d3;
        //                int oldD4 = d4;

        //                int bulls = 0;
        //                int cows = 0;

        //                if (d1 == guess1)
        //                {
        //                    bulls++;
        //                    guess1 = -1;
        //                    d1 = -2;
        //                }

        //                if (d2 == guess2)
        //                {
        //                    bulls++;
        //                    guess2 = -1;
        //                    d2 = -2;
        //                }

        //                if (d3 == guess3)
        //                {
        //                    bulls++;
        //                    guess3 = -1;
        //                    d3 = -2;
        //                }

        //                if (d4 == guess4)
        //                {
        //                    bulls++;
        //                    guess4 = -1;
        //                    d4 = -2;
        //                }

        //                if (d1 == guess2)
        //                {
        //                    cows++;
        //                    guess2 = -1;
        //                }
        //                else if (d1 == guess3)
        //                {
        //                    cows++;
        //                    guess3 = -1;
        //                }
        //                else if (d1 == guess4)
        //                {
        //                    cows++;
        //                    guess4 = -1;
        //                }

        //                if (d2 == guess1)
        //                {
        //                    cows++;
        //                    guess1 = -1;
        //                }
        //                else if (d2 == guess3)
        //                {
        //                    cows++;
        //                    guess3 = -1;
        //                }
        //                else if (d2 == guess4)
        //                {
        //                    cows++;
        //                    guess4 = -1;
        //                }

        //                if (d3 == guess1)
        //                {
        //                    cows++;
        //                    guess1 = -1;
        //                }
        //                else if (d3 == guess2)
        //                {
        //                    cows++;
        //                    guess2 = -1;
        //                }
        //                else if (d3 == guess4)
        //                {
        //                    cows++;
        //                    guess4 = -1;
        //                }

        //                if (d4 == guess1)
        //                {
        //                    cows++;
        //                    guess1 = -1;
        //                }
        //                else if (d4 == guess2)
        //                {
        //                    cows++;
        //                    guess2 = -1;
        //                }
        //                else if (d4 == guess3)
        //                {
        //                    cows++;
        //                    guess3 = -1;
        //                }

        //                d1 = oldD1;
        //                d2 = oldD2;
        //                d3 = oldD3;
        //                d4 = oldD4;

        //                if (bulls == targetBulls && cows == targetCows)
        //                {
        //                    if (solutionFound)
        //                    {
        //                        Console.Write(" ");
        //                    }
        //                    Console.Write("" + d1 + d2 + d3 + d4);
        //                    solutionFound = true;
        //                }
        //            }
        //        }
        //    }
        //}

        //if (!solutionFound)
        //{
        //    Console.WriteLine("No");
        //}
    }
}
