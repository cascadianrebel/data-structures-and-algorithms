using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = Front;

        }

        public void Enqueue(Animal animal)
        {
            while (animal.Pref.ToLower() == "cat" || animal.Pref.ToLower() == "dog")
            {
                Rear.Next = animal;
                Rear = animal;
            }
            return;
        }
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        public Animal Dequeue(string pref)
        {
            string lPref = pref.ToLower();

            if (Front.Pref == lPref)
            {
                return Dequeue();
            }

            Animal temp1 = Front;

            while( Front.Pref != lPref)
            {
                Enqueue(Dequeue());
            }
            Animal temp2 = Dequeue();

            while (Front != temp1)
            {
                Enqueue(Dequeue());
            }

            return temp2;
        }

    }
}
