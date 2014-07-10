using FactoryPattern.Interface;
using System;
using FactoryPattern.Factory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory Animal = new AnimalFactory();

            //Dog
            IAnimal Dog = Animal.SetName("Dog");
            Dog.Talk();
            
            //Cat
            IAnimal Cat = Animal.SetName("Cat");
            Cat.Talk();

            //Cat
            IAnimal Chicken = Animal.SetName("Chicken");
            Chicken.Talk();

            Console.WriteLine("==================== Using Reflection =======================");
            Console.WriteLine("Avoiding Too much switch statement when classes grow.");
            Console.WriteLine("=============================================================");
            
            AnimalFactoryUsingReflection AnimalUsingReflection = new AnimalFactoryUsingReflection();
            IAnimal DogF = AnimalUsingReflection.CreateInstance("Dog");

            DogF.Talk();
            
        }
    }
}
