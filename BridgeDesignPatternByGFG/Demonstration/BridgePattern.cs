using BridgeDesignPatternByGFG.Abstraction;
using BridgeDesignPatternByGFG.ConcreteImplementation;
using BridgeDesignPatternByGFG.RefineAbstraction;

namespace BridgeDesignPatternByGFG.Demonstration;

public static class BridgePattern
{
    public static void Main()
    {

        Vehicle vehicle1 = new Car(new Produce(), new Assemble());
        vehicle1.Manufacture();

        Vehicle vehicle2 = new Bike(new Produce(), new Assemble());

        vehicle2.Manufacture();
    }
}
