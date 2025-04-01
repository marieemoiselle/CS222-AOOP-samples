using System;

// Define an abstract class
abstract class Appliance
{
    public string Brand { get; set; }
    //Number 17
    public abstract void TurnOn();

    //Number 18
    public abstract void TurnOff();

    public void ShowBrand()
    {
        Console.WriteLine($"This is a {Brand} appliance.");
    }
}

class WashingMachine : Appliance
{
    public override void TurnOn() 
    {
        Console.WriteLine("Washing Machine is now ON. Filling water...");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Washing Machine is now OFF. Draining water...");
    }
}

// Another derived class implementing the abstract methods
class Refrigerator : Appliance
{
    public override void TurnOn() 
    {
        Console.WriteLine("Fridge is now ON. Cooling...");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Fridge is now OFF. Defrosting...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        WashingMachine washer = new WashingMachine();
        washer.Brand = "LG";
        washer.ShowBrand();
        washer.TurnOn();
        washer.TurnOff();
        
        Console.WriteLine();
        
        Refrigerator fridge = new Refrigerator();
        fridge.Brand = "Samsung";
        fridge.ShowBrand();
        fridge.TurnOn();
        fridge.TurnOff();
    }
}