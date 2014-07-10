using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Animals
{
    public class Chicken : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Buak Buak");
        }
    }
}
