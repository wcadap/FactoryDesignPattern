using FactoryPattern.Animals;
using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern.Factory
{
    class AnimalFactoryUsingReflection
    {
        Dictionary<string, Type> animals;

        public AnimalFactoryUsingReflection()
        {
            LoadTypesICanReturn();
        }

        public IAnimal CreateInstance(string animalName)
        {
            Type t = GetTypeToCreate(animalName.ToLower());

            if (t == null)
            {
                return new NullAnimal();
            }

            return Activator.CreateInstance(t) as IAnimal;
        }

        Type GetTypeToCreate(string animalName)
        {
            foreach (var animal in animals)
            {
                if (animal.Key.Contains(animalName))
                {
                    return animals[animal.Key];
                }
            }
            return null;
        }

        void LoadTypesICanReturn()
        {
            animals = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IAnimal).ToString()) != null)
                {
                    animals.Add(type.Name.ToLower(),type);
                }
            }
        }

    }
}
