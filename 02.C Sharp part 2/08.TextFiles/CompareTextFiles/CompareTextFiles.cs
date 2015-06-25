//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        using (StreamReader firstReader = new StreamReader(@"..\..\first_file.txt"))
        {
            using (StreamReader secondReader = new StreamReader(@"..\..\second_file.txt"))
            {
                string firstFileLine = firstReader.ReadLine();
                string secondFileLine = secondReader.ReadLine();
                int same = 0;
                int diffrent = 0;

                while (firstFileLine != null)
                {
                    if (firstFileLine.CompareTo(secondFileLine) == 0)
                    {
                        same++;
                    }
                    else
                    {
                        diffrent++;
                    }

                    firstFileLine = firstReader.ReadLine();
                    secondFileLine = secondReader.ReadLine();
                }
                Console.WriteLine("The number of the same lines is: {0}", same);
                Console.WriteLine("The number of the diffrent lines is: {0}", diffrent);
            }
        }
    }
}
