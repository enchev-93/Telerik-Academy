namespace StudentClass
{
    using System;
    using System.Linq;

    public class StudentClassMain
    {
        public static void Main()
        {
            Random rnd = new Random();
            Student[] students = new Student[10];
            string[] firstNames = new string[] { "Ivo", "Niki", "Doncho", "Pesho", "Gosho", "Maria", "Stamat", "Evlogi", "Svetlin", "Stilian" };
            string[] lastNames = new string[] { "Kostov", "Minkov", "Peshev", "Ivanov", "Goshov", "Stamatov", "Kenov", "Popov", "Enchev", "Stanchev" };
            for (int i = 0; i < students.Length; i++)
            {
                string firstName = firstNames[rnd.Next(0, 10)];
                string middleName = lastNames[rnd.Next(0, 10)];
                string lastName = lastNames[rnd.Next(0, 10)];
                long ssn = (long)rnd.Next(111111111, 999999999) + 1000000000;
                Student student = new Student(firstName, middleName, lastName, ssn);
                students[i] = student;
            }

            SortArray(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        private static void SortArray<T>(T[] array) where T : IComparable
        {
            Array.Sort(array);
        }
    }
}
