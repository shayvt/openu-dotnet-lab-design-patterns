using DesignPatterns.FactoryMethod.Factory;

var randomAnimalFactory = new RandomAnimalFactory();

Console.WriteLine("Random Factory");

for (int i = 0; i < 10; i++)
{
    var animal = randomAnimalFactory.CreateAnimal();
    Console.WriteLine($"Created Animal {animal.Name}");
}

Console.WriteLine("--------------------");
Console.WriteLine("Sequential Factory");

var sequentialAnimalFactory = new SequentialAnimalFactory();

for (int i = 0; i < 10; i++)
{
    var animal = sequentialAnimalFactory.CreateAnimal();
    Console.WriteLine($"Created Animal {animal.Name}");
}