﻿//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters 
//more n numbers and calculates and prints their sum.

//Examples:

//numbers	sum
//3	        90
//20	
//60	
//10	

//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	

//1	        1
//1	

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you want to calculate");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number to calculate");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: {0}",
            sum);
    }
}
