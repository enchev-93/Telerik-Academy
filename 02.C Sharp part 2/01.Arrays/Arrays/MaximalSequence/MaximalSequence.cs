//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

using System;

class MaximalSequence
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] numbersString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] sequence = new int[numbersString.Length];
        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = int.Parse(numbersString[i]);
        }
        
        int counter = 1;
        int biggestCounter = 1;
        int currentNumber = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] == sequence[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter > biggestCounter)
            {
                biggestCounter = counter;
                currentNumber = sequence[i];
            }
        }
        if (biggestCounter > 1)
        {
            for (int i = 0; i < biggestCounter; i++)
            {
                Console.Write("{0}", currentNumber);
                if (i != biggestCounter - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No maximal sequence in the array.");
        }
    }
}
