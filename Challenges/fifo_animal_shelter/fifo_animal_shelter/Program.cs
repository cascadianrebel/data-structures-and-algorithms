using System;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            Animal pet1 = new Animal("cat");
            Animal pet2 = new Animal("dog");
            Animal pet3 = new Animal("dog");
            Animal pet4 = new Animal("fish");
            Animal Pet5 = new Animal("cat");


            AnimalShelter animalShelter = new AnimalShelter(pet1);

            animalShelter.Enqueue(pet2);
            animalShelter.Enqueue(pet3);

            Console.WriteLine(animalShelter.Dequeue("dog"));



        }

    }
}
