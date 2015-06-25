//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Linq;

class SayHello
{
    static void Main()
    {
        string name = YourName();
        TestTheName(name);
    }

    static string YourName()
    {
        string name;
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        return name;
    }

    static void TestTheName(string test)
    {
        bool isCorrect = test.All(Char.IsLetter);
        if (isCorrect)
        {
            Console.WriteLine("Hello, {0}!", test);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
