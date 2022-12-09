using DesignPatterns.Builder.Model;

Car familyCar = new(new EngineFourCylinders() { Capacity = 1500 }, new Seats { Count = 5 }, 6);
Car sportCar = new(new EngineV8() { Capacity = 3000 }, new Seats { Count = 4 }, 7, true, true, true);

Console.WriteLine($"Family Car: {familyCar}");
Console.WriteLine($"Sport Car: {sportCar}");

//And we want also to build the car manual...