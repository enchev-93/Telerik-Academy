//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 
//characters. If the length of the string is less than 20, the rest of
//the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        Console.WriteLine(Maximum20CharactersString(text));
    }

    static string Maximum20CharactersString(string text)
    {
        int count = 0;
        if (text.Length > 20)
        {
            text = text.Substring(0, 20);
        }
        else if (text.Length < 20)
        {
            count = 20 - text.Length;
            text += new string('*', count);
        }

        return text;
    }
}
