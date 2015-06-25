//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Text;

class ExtractSentence
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        List<string> sentences = ExtractSentences(text);
        RemoveSentencesWithWord(sentences, word);
        string result = ConvertListToString(sentences);
        Console.WriteLine(result);
    }

    static List<string> ExtractSentences(string text)
    {
        List<string> sentences = new List<string>();

        while (true)
        {
            bool isFinished = false;
            int dotIndex = text.IndexOf('.');
            while (true)
            {
                if (dotIndex == text.Length - 1)
                {
                    isFinished = true;
                    break;
                }

                else if (text[dotIndex + 1] != ' ' || char.IsLower(text[dotIndex + 2]))
                {
                    dotIndex = text.IndexOf('.', dotIndex + 1);
                    continue;
                }

                else
                {
                    break;
                }
            }

            sentences.Add(text.Substring(0, dotIndex + 1));
            if (isFinished)
            {
                break;
            }
            text = text.Substring(dotIndex + 1);
        }

        return sentences;
    }

    static void RemoveSentencesWithWord(List<string> sentences, string word)
    {
        string wordAtStart = char.ToUpper(word[0]) + word.Substring(1) + ' ';
        string wordAtMid = ' ' + word + ' ';
        string wordAtEnd = ' ' + word + '.';

        for (int i = 0; i < sentences.Count; i++)
        {
            if (sentences[i].Contains(wordAtMid) || sentences[i].Contains(wordAtEnd) || sentences[i].Contains(wordAtStart)) 
            {
                continue;
            }
            else
            {
                sentences.RemoveAt(i);
                i--;
            }
        }
    }

    static string ConvertListToString(List<string> text)
    {
        StringBuilder builder = new StringBuilder();
        foreach (var item in text)
        {
            builder.Append(item);
        }

        return builder.ToString();
    }
}