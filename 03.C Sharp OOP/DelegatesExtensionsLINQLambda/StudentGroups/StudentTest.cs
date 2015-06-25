namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        static void Main()
        {
            SolveProblemNine();
            SolveProblemTen();
            SolveProblemEleven();
            SolveProblemTwelve();
            SolveProblemThirteen();
            SolveProblemFourteen();
            SolveProblemFifteen();
            SolveProblemSixteen();
        }

        public static readonly List<Student> students = new List<Student>
        {
            new Student("Pesho", "Peshev", "121205", "0252525252", "peshev@abv.bg", 3,       3, 3, 3, 5, 4, 2),
            new Student("Gosho", "Goshov", "151506", "+359888888888", "gosho@gmail.com", 2,  2, 2, 2, 2),
            new Student("Ivo", "Ivov", "231305", "0423223232", "ivo@abv.bg", 2,              6, 6, 6, 6),
            new Student("Doncho", "Donchov", "777708", "0225252525", "doncho@gmail.bg", 3,   6, 6, 6, 4, 6, 5)
        };

        private static void SolveProblemNine()
        {
            Console.WriteLine("Problem 9:");

            var studentsFromSecondGroup =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in studentsFromSecondGroup)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemTen()
        {
            Console.WriteLine("Problem 10:");

            var studentsFromSecondGroup = students.Where(st => st.GroupNumber == 2)
                                                  .OrderBy(st => st.FirstName);

            foreach (var student in studentsFromSecondGroup)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemEleven()
        {
            Console.WriteLine("Problem 11:");

            var selectedStudents =
                from student in students
                where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemTwelve()
        {
            Console.WriteLine("Problem 12:");

            var selectedStudents =
                from student in students
                where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemThirteen()
        {
            Console.WriteLine("Problem 13:");

            var selectedStudents =
                from student in students
                where student.Marks.Contains(6)
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemFourteen()
        {
            Console.WriteLine("Problem 14:");

            var selectedStudents = students.Where(st => st.Marks.Count(x => Math.Abs(x - 2) < 0.4) == 2);

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemFifteen()
        {
            Console.WriteLine("Problem 15:");

            var selectedStudents = students.Where(st => st.FacultyNumber[4] == '0' && st.FacultyNumber[5] == '6');

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        private static void SolveProblemSixteen()
        {
            Console.WriteLine("Problem 16:");

            var groups = new List<Group>
			             {
							 new Group(1, "Physics"),
							 new Group(2, "Arts"),
							 new Group(3, "Mathematics"),
							 new Group(4, "Law"),
							 new Group(5, "Medicine"),
							 new Group(6, "Biology")
			             };

            var selectedStudents =
                from student in students
                join grp in groups on student.GroupNumber equals grp.GroupNumber
                where grp.DepartmentName == "Mathematics"
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }
    }
}
