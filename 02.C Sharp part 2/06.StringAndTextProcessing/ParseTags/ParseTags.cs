//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();
        Console.WriteLine(ParsingTagsToUpper(text));
    }

    static string ParsingTagsToUpper(string text)
    {
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        int startIndex = 0;
        int endIndex = 0;
        string result = string.Empty;

        while (true)
        {
            startIndex = text.IndexOf(startTag);
            if (startIndex < 0)
            {
                result += text;
                break;
            }
            else
            {
                result += text.Substring(0, startIndex);
                text = text.Substring(startIndex + startTag.Length);
                endIndex = text.IndexOf(endTag);
                result += text.Substring(0, endIndex).ToUpper();
                text = text.Substring(endIndex + endTag.Length);
            }
        }

        return result;
    }
}
