//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//-Side and an altitude to it;
//-Three sides;
//-Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Welcome to the best program ever!");
        Console.WriteLine("This program calculates the surface of a triangle.");
        Console.WriteLine("1. Calculate by side and altitude.");
        Console.WriteLine("2. Calculate by three sides.");
        Console.WriteLine("3. Calculate by two sides and an angle between them.");
        Console.Write("Enter your choise: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude: ");
                double altitude = double.Parse(Console.ReadLine());
                TriangleSurfaceBySideAndAltitude(side, altitude);
                break;
            case 2:
                Console.Clear();
                Console.Write("Enter firsts side: ");
                double firstSide = double.Parse(Console.ReadLine());
                Console.Write("Enter firsts side: ");
                double secondSide = double.Parse(Console.ReadLine());
                Console.Write("Enter firsts side: ");
                double thirdSide = double.Parse(Console.ReadLine());
                TriangleSurfaceByThreeSides(firstSide, secondSide, thirdSide); 
                break;
            case 3:
                Console.Clear();
                Console.Write("Enter first side: ");
                double first = double.Parse(Console.ReadLine());
                Console.Write("Enter first side: ");
                double second = double.Parse(Console.ReadLine());
                Console.Write("Enter angle: ");
                double angle = double.Parse(Console.ReadLine());
                TriangleSurfaceByTwoSidesAndAngleBetweenThem(first, second, angle); 
                break;
            default:
                Console.Clear();
                Console.WriteLine("No such function, sorry!");
                Main();
                break;

        }
    }

    static void TriangleSurfaceBySideAndAltitude(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    static void TriangleSurfaceByThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double p = (firstSide + secondSide + thirdSide) / 2;
        double surface = Convert.ToDouble(Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)));
        Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
        
    }

    static void TriangleSurfaceByTwoSidesAndAngleBetweenThem(double firstSide, double secondSide, double angle)
    {
        double angleRad = (Math.PI * angle) / 180;
        double surface = Convert.ToDouble((firstSide * secondSide * Math.Sin(angleRad)) / 2);
        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }
}
