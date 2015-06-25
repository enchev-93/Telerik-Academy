//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("Nullable integer = {0}", intNumber);
        Console.WriteLine("Nullable double = {0}", doubleNumber);

        intNumber = 102931;
        doubleNumber = 12.3214;

        Console.WriteLine("New value(integer) = {0}", intNumber);
        Console.WriteLine("New value(double) = {0}", doubleNumber);
    }
}
