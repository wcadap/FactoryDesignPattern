using FactoryPattern.Interface;
using System;

namespace FactoryPattern.Animals
{
    class NullAnimal : IAnimal
    {
        void IAnimal.Talk()
        {
            Console.WriteLine("Nothing to Say! Invalid!");
        }
    }
}
