using BridgeDesignPatternByGFG.Implementer;

namespace BridgeDesignPatternByGFG.Abstraction;

public abstract class Vehicle
{
    protected IWorkshop workshop1;
    protected IWorkshop workshop2;

    public Vehicle(IWorkshop workshop1, IWorkshop workshop2) 
                                    => (this.workshop1, this.workshop2) = (workshop1, workshop2);
    abstract public void Manufacture();
}
