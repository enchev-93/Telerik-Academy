//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:

//x     	y	    inside
//0 	    1	    true
//-2	    0	    true
//-1	    2	    false
//1.5	    -1	    true
//-1.5	    -1.5	false
//100	    -30 	false
//0     	0	    true
//0.2	    -0.8	true
//0.9	    -1.93	false
//1	        1.655	true

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter x= ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter y= ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(2, 2);

        Console.Clear();
        Console.WriteLine("Is the point with coordinates \nx = {0} \ny = {1} \nin a circle with radius 2?\n{2}",
            x, y, isInCircle);
    }
}
