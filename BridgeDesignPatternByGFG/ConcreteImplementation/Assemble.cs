using BridgeDesignPatternByGFG.Implementer;

namespace BridgeDesignPatternByGFG.ConcreteImplementation;

public class Assemble : IWorkshop
{
    public void Work()
    {
        Console.WriteLine("and");
        Console.WriteLine("Assemble");
    }
}