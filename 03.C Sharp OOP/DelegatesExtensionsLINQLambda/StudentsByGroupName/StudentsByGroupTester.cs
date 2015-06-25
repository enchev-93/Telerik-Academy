namespace StudentsByGroupName
{
    using System;
    using System.Linq;

    class StudentsByGroupTester
    {
        static void Main()
        {
            Student[] students = GenerateStudentArray();

            Console.WriteLine("LINQ: ");

            var orderedStudents = from st in students
                                  orderby st.GroupName
                                  select st;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Extension methods: ");

            orderedStudents = students.OrderBy(st => st.GroupName);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }

        public static Student[] GenerateStudentArray()
        {
            string[] names = { "Pesho", "Gosho", "Ivo", "John", "Doncho", "Niki", "Evlogi" };

            string[] groups = { "Math", "Bio", "Law", "Computers", "Rockets", "Cows" };

            Random rnd = new Random();

            Student[] students = new Student[rnd.Next(20, 31)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(names[rnd.Next(0, names.Length)], groups[rnd.Next(0, groups.Length)]);
            }

            return students;
        }
    }
}
