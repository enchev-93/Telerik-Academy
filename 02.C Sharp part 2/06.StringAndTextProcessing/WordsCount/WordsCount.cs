//Problem 22. Words count

//Write a program that reads a string from the console and lists all different 
//words in the string along with information how many times each word is found.

using System;

class WordsCount
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ' && !Char.IsLetter(text[i]))
            {
                text = text.Remove(i, 1);
                --i;
            }
        }

        text = text.ToLower();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == string.Empty)
            {
                continue;
            }

            int wordCounter = 1;
            if (i < words.Length - 1)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        ++wordCounter;
                        words[j] = string.Empty;
                    }
                }
            }

            Console.WriteLine("Word: {0,10} repeats {1,2} times", words[i], wordCounter);
        }
    }
}
