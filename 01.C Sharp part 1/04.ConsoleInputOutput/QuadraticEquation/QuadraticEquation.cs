//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).

//Examples:

//a 	b	c	roots
//2	    5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5 	2	8	no real roots

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c");
            double c = double.Parse(Console.ReadLine());
            
            double D = b * b - 4 * a * c;
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("The number of real roots is infinity.");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("There are no any real roots.");
            }
            else if (a == 0 && b != 0)
            {
                double x = -(c / b);
                Console.WriteLine("The equation is linear. The real root is: x = {0}",
                    x);
            }
            else if (D == 0)
            {
                double x = (-b / (2 * a));
                Console.WriteLine("There is only one root: x1 = x2 = {0}",
                    x);
            }
            else if (D < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The real roots are: x1 = {0} and x2 = {1}",
                    x1, x2);
            }
            else
            {
                Console.WriteLine("There are no real roots.");
            }
        }
    }
