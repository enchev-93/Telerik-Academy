namespace DefiningClassesPt2
{
    /// <summary>
    /// Problem 3. Static class
    /// Write a static class with a static method to calculate the distance between two points in the 3D space.
    /// </summary>
    static class CalculateDistanceBetweenTwoPoins
    {
        static Point3D PointDistance (Point3D firstPoint, Point3D secondPoint)
        {
            return new Point3D(firstPoint.X - secondPoint.X, firstPoint.Y - secondPoint.Y, firstPoint.Z - secondPoint.Z);
        }
    }
}
