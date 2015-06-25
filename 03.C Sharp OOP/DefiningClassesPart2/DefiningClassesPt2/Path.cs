namespace DefiningClassesPt2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Problem 4. Path
    /// Create a class Path to hold a sequence of points in the 3D space.
    /// Create a static class PathStorage with static methods to save and load paths from a text file.
    /// Use a file format of your choice.
    /// </summary>
    class Path
    {
        private List<Point3D> points = new List<Point3D>();
        public Path() { }

        public void Add(Point3D point)
        {
            points.Add(point);
        }

        public void Remove(Point3D point)
        {
            points.Remove(point);
        }

        public void Clear()
        {
            points.Clear();
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            foreach (Point3D point in points)
            {
                res.Append(string.Format("Point3D: {0} {1} {2}\n", point.X, point.Y, point.Z));
            }
            return res.ToString();
        }

        public void StoreInFiles(string fileName)
        {
            StreamWriter writer;
            
            using (writer = new StreamWriter(fileName, false))
            {
                foreach (Point3D point in points)
                {
                    writer.WriteLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            StreamReader reader;

            using (reader = new StreamReader(fileName, false))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] values = line.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                    points.Add(new Point3D(values[0], values[1], values[2]));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
