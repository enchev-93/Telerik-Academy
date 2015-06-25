﻿//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text;

class ReplaceWholeWord
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        ReplaceWords(sb);
        WriteFileWithNewText(sb);
        Console.WriteLine("Words are now changed.");
    }

    private static void WriteFileWithNewText(StringBuilder sb)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
        {
            writer.Write(sb);
        }
    }

    private static void ReplaceWords(StringBuilder sb)
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                int index = line.IndexOf("start");

                while (index != -1)
                {
                    if (((index == 0) || (!Char.IsLetter(line[index - 1]))) &&
                        ((index >= (line.Length - 5)) || (!Char.IsLetter(line[index + 5]))))
                    {
                        line = line.Insert(index, "finish").Remove(index + 6, 5);
                        index = line.IndexOf("start");
                    }
                    else
                    {
                        index = line.IndexOf("start", index + 1);
                    }
                }

                sb.Append(line);

                if (!reader.EndOfStream)
                {
                    sb.Append("\r\n");
                }

                line = reader.ReadLine();
            }
        }
    }
}