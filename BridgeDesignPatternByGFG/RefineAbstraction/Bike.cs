using BridgeDesignPatternByGFG.Abstraction;
using BridgeDesignPatternByGFG.Implementer;

namespace BridgeDesignPatternByGFG.RefineAbstraction;

public class Bike : Vehicle
{
    public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
    {
    }

    public override void Manufacture()
    {
        Console.WriteLine("Bike....");

        workshop1.Work();
        workshop2.Work();
    }
}
