using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zoo
{
    public class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            this.animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal);
            Console.WriteLine("Animal added to the zoo");
        }

        public void PrintAnimalsNames()
        {
            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public void MakeAllSounds()
        {
            foreach (var animal in this.animals)
            {
                animal.MakeSound();
            }
        }

        public void GetDietTypes()
        {
            foreach (var animal in this.animals)
            {
                if (animal is IDiet)
                {
                    ((IDiet)animal).GetDietType();
                }
            }
        }

        public void GetHabitatTypes()
        {
            foreach (var animal in this.animals)
            {
                if (animal is IHabitat)
                {
                    ((IHabitat)animal).GetHabitatType();
                }
            }
        }

        public void GetAnimalTypes()
        {
            foreach (var animal in this.animals)
            {
                if (animal is Bird)
                {
                    Console.WriteLine("Bird");
                }
                else if (animal is Mammal)
                {
                    Console.WriteLine("Mammal");
                }
                else if (animal is Fish)
                {
                    Console.WriteLine("Fish");
                }
                else
                {
                    Console.WriteLine("Unknown");
                }
            }
        }
    }
}
