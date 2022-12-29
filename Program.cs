// See https://aka.ms/new-console-template for more informationşşş
using ConsoleApp1.Concrete;

Car carX = new Car(new XEngine(), new XType("Sedan"));
Car carY = new Car(new YEngine(), new YType("Hatchback"));

Console.WriteLine("// CarX \\\\");
carX.Type();
carX.Capacity();

Console.WriteLine();

Console.WriteLine("// CarY \\\\");
carY.Type();
carY.Capacity();
