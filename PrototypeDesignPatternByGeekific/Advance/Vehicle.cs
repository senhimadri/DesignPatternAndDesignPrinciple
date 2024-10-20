namespace PrototypeDesignPatternByGeekific;

public abstract class Vehicle
{
    private string? brands;
    private string? model;
    private string? color { get; set; }

    public Vehicle()
    {

    }

    protected Vehicle(Vehicle vehicle)
    {
        this.brands = vehicle.brands;
        this.model = vehicle.model;
        this.color = vehicle.color;
    }

    public abstract Vehicle Clone();
}
