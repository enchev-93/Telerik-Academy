//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and
//prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words: ");
        string[] words = Console.ReadLine().Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i].CompareTo(words[j]) > 0)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}
