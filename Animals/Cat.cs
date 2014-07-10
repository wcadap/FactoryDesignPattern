using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Animals
{
    public class Cat : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
