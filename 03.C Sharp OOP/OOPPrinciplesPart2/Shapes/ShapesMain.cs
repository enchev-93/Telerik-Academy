namespace Shapes
{
    using System;

    public class ShapesMain
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5.0, 4.5),
                new Triangle(3.1, 7.7),
                new Square(4.4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:F2}", shape.CalculateSurface());
            }
        }
    }
}
