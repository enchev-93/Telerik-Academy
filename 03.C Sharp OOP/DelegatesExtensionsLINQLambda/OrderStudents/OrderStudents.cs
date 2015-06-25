using System;
using System.Linq;

class OrderStudents
{
    /// <summary>
    /// Using the extension methods OrderBy() and ThenBy() with lambda 
    /// expressions sort the students by first name and last name in descending order.
    ///Rewrite the same with LINQ.
    /// </summary>
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Pesho", LastName = "Peshev"},
            new { FirstName = "Gosho", LastName = "Ivov"},
            new { FirstName = "Ivo", LastName = "Goshev"},
            new { FirstName = "Doncho", LastName = "Ivanov"},
            new { FirstName = "Ivan", LastName = "Donchev"},
            new { FirstName = "Niki", LastName = "Nikov"}
        };

        var firstSortedStudents = students.OrderByDescending(st => st.FirstName)
            .ThenByDescending(st => st.LastName);

        var seconSortedStudents =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;

        Console.WriteLine("LINQ extension method:");
        Console.WriteLine(string.Join(Environment.NewLine, firstSortedStudents));
        Console.WriteLine("LINQ querry:");
        Console.WriteLine(string.Join(Environment.NewLine, seconSortedStudents));
    }
}
