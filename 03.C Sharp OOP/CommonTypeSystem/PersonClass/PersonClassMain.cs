namespace PersonClass
{
    using System;

    public class PersonClassMain
    {
        public static void Main()
        {
            Person[] persons = new Person[]
            {
                new Person("Pesho Peshev", 20),
                new Person("Gosho Goshev", 22),
                new Person("Ivo Kenov"),
                new Person("Niki Kostov"),
                new Person("Doncho Minkov"),
                new Person("Evlogi Hristov")
            };

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i]);
            }
        }
    }
}
