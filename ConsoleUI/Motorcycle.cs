using System;
using System.IO;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    public bool HasTwoSideCarts { get; set; }

    public override void DriveAbstract()
    {
        Console.WriteLine($"Cart Type: {HasSideCart}");
        if (HasSideCart == true)
        {
            Console.WriteLine($"This Vehicle has a side cart.");
        }
        else if (HasTwoSideCarts == true)
        {
            Console.WriteLine($"This Vehicle has two sides carts.");
        }
        else
        {
            Console.WriteLine($"This Vehicle Has no side carts.");
        }
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"Motorcycle Statistics: \nYear: {Year} \nMake: {Make} \nModel: {Model}");
    }
}