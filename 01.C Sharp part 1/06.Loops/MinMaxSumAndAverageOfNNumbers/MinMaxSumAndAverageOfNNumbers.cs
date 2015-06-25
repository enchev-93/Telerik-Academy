//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer 
//numbers and returns the minimal, the maximal number, the sum and the 
//average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines,
//each holding an integer number.
//The output is like in the examples below.

//Example 1:

//input	    output
//3	        min = 1
//2     	max = 5
//5	        sum = 8
//1	        avg = 2.67

//Example 2:

//input	output
//2	    min = -1
//-1	max = 4
//4	    sum = 3
//      avg = 1.50

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int input;
        int sum = 0;
        double avg = 0;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        Console.Write("Enter how long the sequence will be: ");
        int count = int.Parse(Console.ReadLine());

        if (count < 1)
        {
            Console.WriteLine("Sorry, can not have negative sequence.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the {0} number",
                i + 1);
            input = int.Parse(Console.ReadLine());

            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
            avg = (double)sum / (double)count;
        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}",
            minValue, maxValue, sum, avg);
    }
}
