using DesignPatterns.Builder.Builders;
using DesignPatterns.Builder.Directors;
using DesignPatterns.Builder.Model;

CarBuilder carBuilder = new();
CarManualBuilder carManualBuilder = new();

// Family Car

FamilyCarDirector familyCarDirector = new();

familyCarDirector.MakeCar(carBuilder);
Car familyCar = carBuilder.Car;
Console.WriteLine($"Family Car: {familyCar}\r\n");

familyCarDirector.MakeCar(carManualBuilder);
CarManual myCarManual = carManualBuilder.CarManual;
Console.WriteLine(myCarManual);

// Sport Car

Console.WriteLine("\r\n\r\n");

SportCarDirector sportCarDirector = new();

sportCarDirector.MakeCar(carBuilder);
Car sportCar = carBuilder.Car;
Console.WriteLine($"Sport Car: {sportCar}\r\n");

sportCarDirector.MakeCar(carManualBuilder);
CarManual sportCarManual = carManualBuilder.CarManual;
Console.WriteLine(sportCarManual);