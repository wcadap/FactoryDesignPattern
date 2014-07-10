using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Animals
{
    public class Duck :IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Quak Quak!");
        }
    }
}
