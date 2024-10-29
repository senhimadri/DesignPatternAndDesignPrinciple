using BridgeDesignPatternByGFG.Abstraction;
using BridgeDesignPatternByGFG.Implementer;

namespace BridgeDesignPatternByGFG.RefineAbstraction;

public class Car : Vehicle
{
    public Car(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1,workshop2)
    {
    }
    public override void Manufacture()
    {
        Console.WriteLine("Car....");

        workshop1.Work();
        workshop2.Work();
    }
}
