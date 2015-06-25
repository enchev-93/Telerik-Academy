using System;
using System.Linq;

class AgeRange
{
    /// <summary>
    /// Write a LINQ query that finds the first name and last name of
    /// all students with age between 18 and 24.
    /// </summary>
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Pesho", LastName = "Peshev", Age = 20},
            new { FirstName = "Gosho", LastName = "Goshev", Age = 18},
            new { FirstName = "Ivo", LastName = "Ivov", Age = 22},
            new { FirstName = "Doncho", LastName = "Donchev", Age = 24},
            new { FirstName = "Ivan", LastName = "Ivanov", Age = 17},
            new { FirstName = "Niki", LastName = "Nikov", Age = 28}
        };

        var sortedStudents =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

        Console.WriteLine("LINQ querry:");
        Console.WriteLine(string.Join(Environment.NewLine,sortedStudents));
    }
}
