//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be 
//divided (without remainder) by 7 and 5 at the same time.
//Examples:

//n	   Divided by 7 and 5?
//3	    false
//0	    false
//5	    false
//7 	false
//35	true
//140	true

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter number ");
        int n = int.Parse(Console.ReadLine());
        bool checker = (n % 7 == 0 && n % 5 == 0 && n != 0);

        Console.Clear();
        Console.WriteLine("Can {0} be divided by 7 and 5 without remainder? \n{1}" ,
            n, checker);
    }
}
