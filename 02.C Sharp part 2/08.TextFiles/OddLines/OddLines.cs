//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        // you can use .txt files too, just create one and put its name below
        StreamReader reader = new StreamReader(@"..\..\OddLines.cs");

        using (reader)
        {
            int lineCounter = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                ++lineCounter;

                if (lineCounter % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineCounter, line);
                }
                line = reader.ReadLine();
            }
        }
    }
}
