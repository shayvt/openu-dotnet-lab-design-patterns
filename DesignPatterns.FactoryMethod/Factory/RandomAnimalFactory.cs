namespace DesignPatterns.FactoryMethod.Factory;

internal class RandomAnimalFactory : AnimalFactory
{
    private static readonly Random _random = new Random();

    public Animal CreateAnimal()
    {
        var randNum = _random.Next(0, 4);

        switch (randNum % 3)
        {
            case 0:
                return new Bird();
            case 1:
                return new Cat();
            case 2:
                return new Dog();
            default:
                return new Dog();
        }
    }
}
