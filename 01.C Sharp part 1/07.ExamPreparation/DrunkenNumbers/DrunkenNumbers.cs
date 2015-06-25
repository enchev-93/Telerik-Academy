using System;

class DrunkenNumbers
{
    static void Main()
    {
        int numberOfRounds = int.Parse(Console.ReadLine());
        int rightDigitSum = 0;
        int leftDigitsSum = 0;

        if (1 <= numberOfRounds && numberOfRounds <= 100)
        {
            for (int i = 1; i <= numberOfRounds; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 0)
                {
                    currentNumber *= -1;
                }

                int numberOfDigits = 0;
                int num = currentNumber;
                while (num != 0)
                {
                    num /= 10;
                    numberOfDigits++;
                }

                for (int right = 0; right < numberOfDigits / 2; right++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    rightDigitSum += currentDigit;
                }

                if (numberOfDigits % 2 == 1)
                {
                    int middleDigit = currentNumber % 10;
                    leftDigitsSum += middleDigit;
                    rightDigitSum += middleDigit;
                    currentNumber /= 10;
                }

                for (int left = 0; left < numberOfDigits / 2; left++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    leftDigitsSum += currentDigit;
                }
            }

            int diffrence = leftDigitsSum - rightDigitSum;
            if (diffrence > 0)
            {
                Console.WriteLine("M {0}", Math.Abs(diffrence));
            }
            else if (diffrence < 0)
            {
                Console.WriteLine("V {0}", Math.Abs(diffrence));
            }
            else
            {
                Console.WriteLine("No {0}", rightDigitSum + leftDigitsSum);
            }
        }
    }
}

