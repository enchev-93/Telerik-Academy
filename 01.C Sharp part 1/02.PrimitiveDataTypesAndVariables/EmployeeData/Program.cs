//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. 
//Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee
//using appropriate primitive data types. Use descriptive names. 
//Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        if (age > 100)
        {
            Console.WriteLine("You are damn old! Go rest!");
        }

        Console.WriteLine("Enter gender \nm for male, f for female: ");
        char gender = char.Parse(Console.ReadLine());
        char male = 'm';
        char female = 'f';
        if (gender != male)
        {
            if (gender != female)
                Console.WriteLine("Not a valid gender, sorry!");
        }
        
        Console.WriteLine("Enter personal ID number: ");
        long personalIDNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter unique empoloyee number: ");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
    }
}
