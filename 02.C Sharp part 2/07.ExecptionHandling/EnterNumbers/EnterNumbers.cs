//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumber
{
    static void RunTenTimes(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(start, end);
        }
    }

    static void ReadNumber(int start, int end)
    {
        string input = Console.ReadLine();
        try
        {
            int number = int.Parse(input);
            if (number > start && number < end)
            {
                Console.WriteLine("{0} is in range.", number);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException ax)
        {
            Console.WriteLine("Invalid input! \r\n{0}", ax.Message);
        }
        catch (FormatException fx)
        {
            Console.WriteLine("Invalid input! \r\n{0}", fx.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("Invalid input! \r\n{0}", oe.Message);
        }
    }

    static void Main()
    {
        Console.Write("10 runs: ");
        RunTenTimes(0, 100);
    }
}
