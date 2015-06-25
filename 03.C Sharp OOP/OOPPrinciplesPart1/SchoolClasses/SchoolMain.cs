namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolMain
    {
        public static void Main()
        {
            School school = new School("Test school");
            Console.WriteLine("School name: \"{0}\"\n", school.Name);

            var students = new List<Student>
            {
                new Student("Pesho", 1, "Class leader"),
                new Student("Gosho", 2),
                new Student("Ivo", 3),
                new Student("Doncho", 4)
            };

            Console.WriteLine("\nList of students: \n");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            var disciplines = new List<Discipline>
            {
                new Discipline("Math", 15, 15)
            };

            Discipline physics = new Discipline("Physics", 10, 10);
            disciplines.Add(physics);

            Console.WriteLine("\n\nList of disciplines:\n");

            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline);
                Console.WriteLine();
            }

            Teacher peshov = new Teacher("Pesho Peshov", new List<Discipline>() { new Discipline("Physics", 10, 10) });
            Teacher goshev = new Teacher("Gosho Goshev", new List<Discipline>() { new Discipline("Math", 10, 10) });

            List<Teacher> teachers = new List<Teacher>() { peshov, goshev };

            Console.WriteLine("\nList of teachers:\n");

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine("{0} {1}", teacher.FullName, string.Join("\n", teacher.DisciplinesList));
                Console.WriteLine();
            }

            Class tenA = new Class("10 A",
                new List<Teacher>() { peshov },
                new List<Student>() { new Student("Toshko", 1), new Student("Peshka", 2) });

            Console.WriteLine("\nClass: ");
            Console.WriteLine(tenA);

            tenA.Comment = "Very good results last year!";
            Console.WriteLine("\n\nClass \"{0}\" comment: {1}\n", tenA.ClassID,tenA.Comment);
        }
    }
}
