//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	output
//Hi!	\u0048\u0069\u0021

using System;

class UnicodeCharacters
{
    static void Main()
    {
        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();
        string text = "Hi!";

        foreach (var item in text)
        {
            string output = String.Format("\\u{0:X4}", (int)(item));
            Console.Write(output);
        }

        Console.WriteLine();
    }
}