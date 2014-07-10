using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Animals
{
    class Dog : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Aw aw!");
        }
    }
}
