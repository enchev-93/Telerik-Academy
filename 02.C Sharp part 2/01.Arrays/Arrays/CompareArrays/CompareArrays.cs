//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and 
//compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter how big you want the first array: ");
        int firstArrayLenght = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArrayLenght];
        for (int i = 0; i < firstArrayLenght; i++)
        {
            Console.Write("Enter element {0} for first array: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter how big you want the second array: ");
        int secondArrayLenght = int.Parse(Console.ReadLine());

        int[] secondArray = new int[secondArrayLenght];
        for (int i = 0; i < secondArrayLenght; i++)
        {
            Console.Write("Enter element {0} for second array: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;

        if (firstArrayLenght == secondArrayLenght)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else
        {
            equal = false;
        }
        Console.WriteLine("Equal? --> {0}", equal);
    }
}
