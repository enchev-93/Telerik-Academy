//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input 	output
//.NET	    platform for applications from Microsoft
//CLR	    managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;

class WordDictionary
{
    static void Main()
    {
        string[] dictionary =
        {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical organization of classes"
        };

        Console.Write("Enter search word: ");
        string searchWord = Console.ReadLine();
        searchWord = searchWord.ToLower();
        int index = -1;
        for (int i = 0; i < dictionary.Length; i++)
        {
            string firstWord = dictionary[i].Substring(0, dictionary[i].IndexOf(" - "));
            firstWord = firstWord.ToLower();
            if (searchWord == firstWord)
            {
                index = i;
                break;
            }
        }

        if (index >= 0)
        {
            Console.WriteLine(dictionary[index]);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }
}