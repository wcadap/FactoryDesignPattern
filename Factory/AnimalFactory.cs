using FactoryPattern.Animals;
using FactoryPattern.Interface;

namespace FactoryPattern.Factory
{
    public class AnimalFactory
    {
        public IAnimal SetName(string Name) {
            IAnimal theAnimal = null;

            string _NameLowerCase = Name.ToLower();

            switch (_NameLowerCase)
            {
                case "dog" :
                    theAnimal = new Dog();
                    break;
                case "cat":
                    theAnimal = new Cat();
                    break;
                case "chicken":
                    theAnimal = new Chicken();
                    break;
                case "duck":
                    theAnimal = new Duck();
                    break;
            }

            return theAnimal;
        }
    }
}
