namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        static void Main()
        {
            var animalTypes = new List<string> { "Cat", "Kitten", "Tomcat", "Dog", "Frog" };

            Animal[] animals =
            {
                new Kitten("Kittie", 1),
                new Kitten("Kit", 2),
                new Tomcat("Tom", 3),
                new Tomcat("Tommas", 2),
                new Cat("Caty", 4, Gender.Female),
                new Cat("Pesho", 5, Gender.Male),
                new Dog("Dogo", 2, Gender.Male),
                new Dog("Doga", 6, Gender.Female),
                new Frog("Frogo", 1, Gender.Male),
                new Frog("Froga", 2, Gender.Female)
            };


            Console.WriteLine("Animals:\n");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine("{0} says: ", animal.GetType().Name);
                animal.ProduceSound();
                Console.WriteLine();
            }

            Console.WriteLine("\nAnimals' average age:\n");
            AverageAgeByAnimalType(animals, animalTypes);
            Console.WriteLine();
            
        }

        private static void AverageAgeByAnimalType(IEnumerable<Animal> animals, IEnumerable<string> animalTypes)
        {
            foreach (var type in animalTypes)
            {
                double averageAge =
                    (from animal in animals
                     where Equals(animal.GetType().Name, type)
                     select (double)animal.Age)
                         .Average();

                Console.WriteLine("{0}: {1:F2} years", type, averageAge);
            }
        }
    }
}
