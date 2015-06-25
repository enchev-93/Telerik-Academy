namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersMain
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Pesho", "Peshev", 4.2),
                new Student("Gosho", "Goshev", 6),
                new Student("Ivan", "Ivanov", 3.17),
                new Student("Ivo", "Ivov", 5.4),
                new Student("Doncho", "Donchev", 5.7),
                new Student("Niki", "Nikev", 3.55),
                new Student("Evlogi", "Evlogiev", 4.67),
                new Student("Qnka", "Qnkova", 3.15),
                new Student("Plamen", "Plamenov", 2.75),
                new Student("Teodora", "Teodorova", 4.35),
            };

            var ascendingSortedStudents = students.OrderBy(st => st.Grade);

            Console.WriteLine("Students sorted(ascending) by grade:\n");
            Console.WriteLine(string.Join("\n", ascendingSortedStudents));

            var workers = new List<Worker>
            {
                new Worker("Pesho", "Goshev", 400, 8),
                new Worker("Gosho", "Peshev", 350, 8),
                new Worker("Ivailo", "Kenov", 480, 8),
                new Worker("Niki", "Kolev", 353, 8),
                new Worker("Petyr", "Stamatov", 4205, 8),
                new Worker("Stamat", "Petrov", 1207, 8),
                new Worker("Kristiqn", "Stefanov", 760, 8),
                new Worker("Stefan", "Kristiqnov", 333, 8),
                new Worker("Veselin", "Cholakov", 555, 8),
                new Worker("Cholak", "Veselinov", 1007, 8),
            };


            var moneyPerHourSortedDescendingWorkers =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("\nWorkers sorted(descending) by money per hour");
            Console.WriteLine(string.Join("\n", moneyPerHourSortedDescendingWorkers));

            var mergeStudentsAndWorkers = new List<Human>();
            mergeStudentsAndWorkers.AddRange(students);
            mergeStudentsAndWorkers.AddRange(workers);

            var sortedHumans = mergeStudentsAndWorkers.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            Console.WriteLine("\nStudents and workers merged and sorted by first and last name:\n");

            foreach (Human man in sortedHumans)
            {
                Console.WriteLine("{0} {1}", man.FirstName, man.LastName);
            }

            Console.WriteLine();
        }
    }
}
