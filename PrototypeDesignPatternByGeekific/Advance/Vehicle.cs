namespace PrototypeDesignPatternByGeekific;

public abstract class Vehicle
{
    private string? brands;
    private string? model;
    private string? color;

    public Vehicle(string? brand, string? model, string? color)
    {
        this.brands = brand;
        this.model = model;
        this.color = color;
    }
    protected Vehicle(Vehicle vehicle)
    {
        this.brands = vehicle.brands;
        this.model = vehicle.model;
        this.color = vehicle.color;
    }
    public abstract Vehicle Clone();
}
