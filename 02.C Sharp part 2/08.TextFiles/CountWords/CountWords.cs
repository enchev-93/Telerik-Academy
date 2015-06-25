//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class CountWords
{
    static void Main()
    {
        try
        {
            string[] text = ReadText();
            string[] words = ReadWords();
            Dictionary<string, int> wordsDictionary = CountWordsOccurance(text, words);
            PrintResult(wordsDictionary);
            Console.WriteLine("Words are counted.");
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine(fnf.Message);
        }
        catch (DirectoryNotFoundException dnf)
        {
            Console.WriteLine(dnf.Message);
        }
        catch (PathTooLongException ptl)
        {
            Console.WriteLine(ptl.Message);
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message);
        }
        catch (UnauthorizedAccessException ua)
        {
            Console.WriteLine(ua.Message);
        }
        catch (OverflowException oe)
        {
            Console.WriteLine(oe.Message);
        }
        catch (OutOfMemoryException oom)
        {
            Console.WriteLine(oom.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }

    static void PrintResult(Dictionary<string, int> wordsDictionary)
    {
        var sortedDictionary = wordsDictionary.OrderByDescending(x => x.Value);
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            string output = string.Empty;

            foreach (var item in sortedDictionary)
            {
                writer.WriteLine("The word '{0}' appears {1} times in the text.", item.Key, item.Value);
            }
        }
    }

    static Dictionary<string, int> CountWordsOccurance(string[] text, string[] words)
    {
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        int counter = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == words[i])
                {
                    counter++;
                }
            }

            wordsDictionary.Add(words[i], counter);
            counter = 0;
        }

        return wordsDictionary;
    }

    static string[] ReadText()
    {
        string[] text;

        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            text = reader.ReadToEnd().Replace("\r\n", " ").Replace(".", " ").Split(' ');
        }

        return text;
    }

    static string[] ReadWords()
    {
        string[] words;

        using (StreamReader reader = new StreamReader(@"..\..\words.txt"))
        {
            words = reader.ReadToEnd().Replace("\r\n", " ").Split(' ');
        }
        return words;
    }
}
