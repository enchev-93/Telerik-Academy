//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	    4	    14	        12
//2.5	3	    11      	7.5
//5	    5	    20      	25

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter Width ");
        double numberWidth = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Height ");
        double numberHeight = double.Parse(Console.ReadLine());

        Console.Clear();
        double perimeter = (numberWidth * 2) + (numberHeight * 2);
        Console.WriteLine("Perimeter of the rectangle is: {0}",
            perimeter);

        double area = (numberHeight * numberWidth);
        Console.WriteLine("Area of the rectangle is: {0}",
            area);
    }
}
