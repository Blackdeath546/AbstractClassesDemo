using System;
using System.IO;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = "1901";
    public string Make { get; set; } = "Generic";
    public string Model { get; set; } = "000 Default";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"Car Statistics: \nYear: {Year} \nMake: {Make} \nModel: {Model}");
    }

}