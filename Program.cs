using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalandinterfaceEdible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal[] animals = new animal[2];
            animals[0] = new tiger();
            animals[1] = new Chicken();

            foreach (animal animal in animals)
            {
                Console.WriteLine(animal.Makesound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.howtoEat());
                }
            }
        }
    }
}
