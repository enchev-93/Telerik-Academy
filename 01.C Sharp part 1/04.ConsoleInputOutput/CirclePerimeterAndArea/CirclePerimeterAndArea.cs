//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	     perimeter	area
//2	     12.57	    12.57
//3.5	 21.99	    38.48

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Insert circle radiur r = ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = (radius * 2 * Math.PI);
        double area = (radius * radius * Math.PI);

        Console.Clear();
        Console.WriteLine("With radius {0} the perimeter of the circle is: {1:F2} and the area is: {2:F2}",
            radius, perimeter, area);
    }
}
