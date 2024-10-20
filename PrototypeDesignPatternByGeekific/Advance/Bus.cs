namespace PrototypeDesignPatternByGeekific;

public class Bus : Vehicle
{
    private int doors;

    public Bus(string? brand, string? model, string? color, int doors) : base(brand, model, color)
    {
        this.doors = doors; 
    }

    public Bus(Bus bus) : base(bus)
    {
        this.doors = bus.doors;
    }

    public override Vehicle Clone()
    {
        return new Bus(this);
    }
}