using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.MakeSound();

            List<IAnimal> animals = new List<IAnimal>
            {
                    new Dog(),new Cat(), new Cow()
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

        }     
    }

    interface IAnimal
    {
        void MakeSound();
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cow : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Boooo");
        }
    }
}
