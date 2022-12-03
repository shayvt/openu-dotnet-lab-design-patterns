using System;

namespace DesignPatterns.FactoryMethod.Factory;

internal class SequentialAnimalFactory : AnimalFactory
{
    private static int lastAnimalIndex = 0;

    public Animal CreateAnimal()
    {
        switch (lastAnimalIndex % 3)
        {
            case 0:
                lastAnimalIndex++;
                return new Bird();
            case 1:
                lastAnimalIndex++;
                return new Cat();
            case 2:
                lastAnimalIndex = 0;
                return new Dog();
            default:
                return new Dog();
        }
    }
}
