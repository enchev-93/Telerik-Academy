//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumber
{
    static void Main()
    {
        using (StreamWriter write = new StreamWriter(@"..\..\text_with_lines.txt"))
        {
            using (StreamReader read = new StreamReader(@"..\..\text.txt"))
            {
                string line = read.ReadLine();
                int countLines = 1;

                while (line != null)
                {
                    write.WriteLine("{0:D2}: {1}", countLines, line);
                    line = read.ReadLine();
                    ++countLines;
                }
            }
        }
    }
}
