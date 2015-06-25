//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is 
//equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, 
//the second is even, etc.

//Examples:

//numbers	         result
//2 1 1 6 3	         yes
//product = 6
	
//3 10 4 6 5 1	     yes
//product = 60	

//4 3 2 5 2 	     no
//odd_product = 16	
//even_product = 15	

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers in a line, separated by space");
        string lineNumbers = Console.ReadLine();
        string[] numbers = lineNumbers.Split(' ');
        int length = numbers.Length;
        
        int oddProduct = 1;
        int evenProduct = 1;
        
        for (int i = 0; i < length; i++)
        {
            int number;
            bool isNumber = int.TryParse(numbers[i], out number);
            if (isNumber)
            {
                if (i % 2 != 0)
                {
                    oddProduct *= number;
                }
                else if (i % 2 == 0)
                {
                    evenProduct *= number;
                }
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("Is the product even? - yes");
            Console.WriteLine("The product is = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("Is the product even? - no");
            Console.WriteLine("The even product is = {0}\nThe odd product is = {1}",
                evenProduct, oddProduct);
        }

    }
}
