namespace DefiningClassesPt2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    [Version("2.11")]
    public class MainProgram
    {
        static void Main()
        {
            // Problems 01 - 04
            Console.WriteLine("Class point3D");
            Console.WriteLine();
            Path points = new Path();
            points.Add(new Point3D(Point3D.O.X, Point3D.O.Y, Point3D.O.Z));
            points.Add(new Point3D(1, 1, 1));
            points.Add(new Point3D(2, 2, 2));
            points.Add(new Point3D(3, 3, 3));

            Console.WriteLine("Points in the object");
            Console.WriteLine(points);

            try
            {
                Console.WriteLine("Store points in file");
                points.StoreInFiles("test.txt");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error writing the file.");
                return;
            }

            Console.WriteLine("Clear points");
            points.Clear();

            try
            {
                Console.WriteLine("Read from file: ");
                points.LoadFromFile("test.txt");
                Console.WriteLine(points);
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Error writing in file.");
                return;
            }

            // Problems 08 - 11
            Matrix<double> matrix1 = new Matrix<double>(5, 4);
            Matrix<double> matrix2 = new Matrix<double>(5, 4);
            Console.WriteLine("Matrix generix");
            Console.WriteLine();

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    matrix1[x, y] = x + y;
                    matrix2[x, y] = (x + y) * 2;
                }
            }

            Console.WriteLine("Matrix1");
            Console.WriteLine(matrix1);

            Console.WriteLine("Matrix2");
            Console.WriteLine(matrix2);

            Console.WriteLine("Matrix1 + Matrix2");
            Console.WriteLine(matrix1 + matrix2);

            Console.WriteLine("Matrix1 - Matrix2");
            Console.WriteLine(matrix1 - matrix2);

            Console.WriteLine("Matrix1 * Matrix2");
            Console.WriteLine(matrix1 * matrix2);

            Console.WriteLine("Is matrix 1 true? ");
            if (matrix1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            // Reflection
            Console.WriteLine();
            Console.WriteLine("Attributes");
            Type type = typeof(MainProgram);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine("Version: " + item.Verson);
            }

        }
    }
}
