using System;

namespace ConsoleUI;

public class Car : Vehicle
{ 
    public bool HasFwd { get; set; }
    public bool HasTwd { get; set; }

    public override void DriveAbstract()
    {
        if (HasFwd == true)
        {
            Console.WriteLine($"This Vehicle has has Fwd");
        }
        else if (HasTwd == true)
        {
            Console.WriteLine($"This Vehicle has Twd");
        }
        else
        {
            Console.WriteLine($"This Vehicle Can't Drive");
        }
    }
}