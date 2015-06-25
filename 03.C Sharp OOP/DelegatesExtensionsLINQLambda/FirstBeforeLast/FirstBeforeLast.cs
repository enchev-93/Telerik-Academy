using System;
using System.Linq;

class FirstBeforeLast
{
    /// <summary>
    /// Write a method that from a given array of students finds all 
    /// students whose first name is before its last name alphabetically.
    ///Use LINQ query operators.
    /// </summary>
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Pesho", LastName = "Peshev"},
            new { FirstName = "Gosho", LastName = "Goshev"},
            new { FirstName = "Ivo", LastName = "Ivov"},
            new { FirstName = "Doncho", LastName = "Donchev"},
            new { FirstName = "Ivan", LastName = "Ivanov"},
            new { FirstName = "Niki", LastName = "Nikov"}
        };

        var linqQuerry = 
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        var extensionMethod = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);

        Console.WriteLine("LINQ querry:");
        Console.WriteLine(string.Join(Environment.NewLine, linqQuerry));
        Console.WriteLine();
        Console.WriteLine("LINQ extension method:");
        Console.WriteLine(string.Join(Environment.NewLine, extensionMethod));

    }
}
