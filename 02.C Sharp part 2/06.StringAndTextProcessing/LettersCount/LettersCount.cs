//Problem 21. Letters count

//Write a program that reads a string from the console and prints all 
//different letters in the string along with information how many times each letter is found.

using System;

class LettersCount
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();

        while (text != string.Empty)
        {
            char letter = text[0];
            text = text.Substring(1);

            int letterCount = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    text = text.Remove(i, 1);
                    --i;
                    ++letterCount;
                }
            }

            if (Char.IsLetter(letter))
            {
                Console.WriteLine("Char: {0} repeats {1,2} times.", letter, letterCount);
            }
        }
    }
}
