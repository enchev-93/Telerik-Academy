using System;

class Digits
{
    static void Main()
    {
        string input = Console.ReadLine();

        long[] numbers = ConvertStringToInt(input);
        long diffrence = 0;
        long sum = 0;

        for (long i = 1; i < numbers.Length; i++)
        {
            diffrence = Math.Abs(numbers[i] - numbers[i - 1]);
            
            if (diffrence % 2 != 0)
            {
                sum += diffrence;
            }

            if (diffrence % 2 == 0)
            {
                i++;
            }
        }

        Console.WriteLine(sum);
    }

    static long[] ConvertStringToInt(string input)
    {
        string[] numbersString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        long[] numbers = new long[numbersString.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = long.Parse(numbersString[i]);
        }

        return numbers;
    }
}
