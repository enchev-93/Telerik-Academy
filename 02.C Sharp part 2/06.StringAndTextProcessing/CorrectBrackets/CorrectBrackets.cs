//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        Console.WriteLine(CheckForBrackets(expression) ? "Correct" : "Incorrect");
    }

    static bool CheckForBrackets(string expression)
    {
        int bracket = 0;

        foreach (var symbol in expression)
        {
            if (symbol == '(')
            {
                bracket++;
            }
            else if (symbol == ')')
            {
                bracket--;
            }

            if (bracket < 0)
            {
                return false;
            }
        }

        return bracket == 0;
    }
}
