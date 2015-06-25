//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an
//int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//      program           	user
//Please choose a type:	
//1 --> int	
//2 --> double	            3
//3 --> string	
//Please enter a string:	hello
//hello*	

//Example 2:

//      program	            user
//Please choose a type:	
//1 --> int	
//2 --> double	            2
//3 --> string	
//Please enter a double:	1.5
//2.5	

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int program = int.Parse(Console.ReadLine());

            if (program < 1 || program > 3)
            {
                Console.WriteLine("no such program, try again");
            }

            switch (program)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("resul: " + (a + 1));
                    break;

                case 2:
                    Console.Write("Please enter a double (use dot): ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("result: " + (b + 1));
                    break;

                case 3:
                    Console.Write("Please enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("result: {0}*",
                        c);
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Not valid, man");
        }
        
    }
}
