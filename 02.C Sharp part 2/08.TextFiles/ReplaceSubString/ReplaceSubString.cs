//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

class ReplaceSubString
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        ReplaceWords(sb);
        WriteFileWithNewText(sb);
        Console.WriteLine("Sub-strings are changed now.");
    }

    static void ReplaceWords(StringBuilder sb)
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                sb.Append(line).Replace("start", "finish");

                if (!reader.EndOfStream)
                {
                    sb.Append("\r\n");
                }

                line = reader.ReadLine();
            }
        }
    }

    static void WriteFileWithNewText(StringBuilder sb)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
        {
            writer.Write(sb);
        }
    }
}
