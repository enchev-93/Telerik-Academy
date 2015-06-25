//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	output.txt
//Ivan        George
//Peter       Ivan
//Maria       Maria
//George	  Peter

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class SaveSortedNames
{
    static void Main()
    {
        List<string> namesList = new List<string>();
        ReadFile(namesList);
        namesList.Sort();
        WriteToFile(namesList);
        Console.WriteLine("Names are sorted now");

    }

    static void WriteToFile(List<string> namesList)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\sorted_names.txt"))
        {
            foreach (string name in namesList)
            {
                writer.WriteLine(name);
            }
        }
    }

    static void ReadFile(List<string> namesList)
    {
        using (StreamReader reader = new StreamReader(@"..\..\names.txt", Encoding.UTF8))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                namesList.Add(line);
                line = reader.ReadLine();
            }
        }
    }
}
