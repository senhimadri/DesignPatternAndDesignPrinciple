namespace PrototypeDesignPatternByGeekific;

public class Bus : Vehicle
{
    private int doors;

    public Bus() { }

    public Bus(Bus bus) : base(bus)
    {
        this.doors = bus.doors;
    }

    public override Vehicle Clone()
    {
        return new Bus(this);
    }
}