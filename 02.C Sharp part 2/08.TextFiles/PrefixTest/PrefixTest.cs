﻿//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text;

class PrefixTest
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        DeleteWords(sb);
        WriteTheFile(sb);
        Console.WriteLine("All \"test\" words are deleted.");

    }

    static void DeleteWords(StringBuilder sb)
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            string line = string.Empty;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    if (word.Length <= 3)
                    {
                        sb.Append(word).Append(' ');
                    }
                    else if ((word[0] == 't') && (word[1] == 'e') && (word[2] == 's') && (word[3] == 't'))
                    {
                        sb.Append(' ', word.Length).Append(' ');
                    }
                    else
                    {
                        sb.Append(word).Append(' ');
                    }
                }

                if (!reader.EndOfStream)
                {
                    sb.Append("\r\n");
                }
            }
        }
    }
    
    static void WriteTheFile(StringBuilder sb)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\test.txt"))
        {
            writer.Write(sb);
        }
    }
}
