//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//- Reverses the digits of a number
//- Calculates the average of a sequence of integers
//- Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//- The decimal number should be non-negative
//- The sequence should not be empty
//- a should not be equal to 0

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Welcome to the best program ever!");
        Console.WriteLine("Here you can:");
        Console.WriteLine("1. Reverse the digits of a number.");
        Console.WriteLine("2. Calculate the average of a sequence.");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        Console.Write("Choose an operation: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (choice)
        {
            case 1:
                Reverser();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("Thank you for using our services!");
                Console.WriteLine("Please, come back again!");
                break;
            case 2:
                AverageCalculater();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("Thank you for using our services!");
                Console.WriteLine("Please, come back again!");
                break;
            case 3:
                LinearEquation();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("Thank you for using our services!");
                Console.WriteLine("Please, come back again!");
                break;
            default:
                Console.WriteLine("Sorry, no such option!");
                Menu();
                break;
        }
    }
    static void Reverser()
    {
        Console.Write("Enter decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.Clear();
            Console.WriteLine("The decimal number should be non-negative!");
            Reverser();
        }
        else
        {
            decimal reverse = decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
            Console.WriteLine("Reversed: {0}", reverse);
        }
    }

    static void AverageCalculater()
    {
        try
        {
            Console.Write("Enter how long you want your sequence: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }
            average = average / n;
            Console.WriteLine("The average is: {0}", average);
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Sequence should not be empty!");
            AverageCalculater();
        }

    }

    static void LinearEquation()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.Clear();
            Console.WriteLine("a should not be equal to 0!");
            LinearEquation();
        }
        else
        {
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            if (b >= 0)
            {
                Console.WriteLine("{0} * x + {1} = 0", a, b);
            }
            else if (b < 0)
            {
                Console.WriteLine("{0} * x {1} = 0", a, b);
            }

            double sum = 0;
            sum += -b / (double)a;

            Console.WriteLine("x = {0}", sum);
        }
    }
}
