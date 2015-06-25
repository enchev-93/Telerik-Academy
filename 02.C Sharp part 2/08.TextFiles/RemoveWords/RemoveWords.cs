//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;
using System.Linq;

class RemoveWords
{
    static void Main()
    {
        try
        {
            string text = ReadText();
            string[] words = ReadWords();

            RemoveListedWords(text, words);
            Console.WriteLine("Words are removed.");
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

    static string ReadText()
    {
        string text = string.Empty;

        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            text = reader.ReadToEnd();
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

    static void RemoveListedWords(string text, string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            text = text.Replace(words[i], "");
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
        {
            writer.Write(text);
        }
    }
}
