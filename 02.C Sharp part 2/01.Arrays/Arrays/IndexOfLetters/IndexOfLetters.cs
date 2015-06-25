//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(65 + i);
        }

        Console.Write("Enter words with letters for review: ");
        string input = Console.ReadLine();
        string upperInput = input.ToUpper();

        foreach (char aChar in upperInput)
        {
            if (aChar < 'A' && aChar > 'Z')
            {
                continue;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (aChar == alphabet[i])
                {
                    Console.WriteLine("Letter {0} corresponds to index {1} of the array.", aChar, i);
                }
            }
        }
    }
}
