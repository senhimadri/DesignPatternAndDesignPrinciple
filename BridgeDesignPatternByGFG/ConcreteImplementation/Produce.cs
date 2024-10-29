using BridgeDesignPatternByGFG.Implementer;

namespace BridgeDesignPatternByGFG.ConcreteImplementation;

public class Produce : IWorkshop
{
    public void Work()
    {
        Console.WriteLine("Produce");
    }
}
