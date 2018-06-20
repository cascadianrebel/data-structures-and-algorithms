using System;
using Xunit;
using fifo_animal_shelter;
using static fifo_animal_shelter.AnimalShelter;

namespace XUnitTestAnimalShelter
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueDog()
        {
            Animal pet1 = new Animal("cat");
            Animal pet2 = new Animal("dog");
            Animal pet3 = new Animal("dog");


            AnimalShelter animalShelter = new AnimalShelter(pet1);

            animalShelter.Enqueue(pet2);

            Assert.Equal(pet2, animalShelter.Rear);
        }
    }
}
