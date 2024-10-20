namespace PrototypeDesignPatternByGeekific.Initial;

public class Car : IPrototype
{
    private string? brands { get; set; }
    private string? model { get; set; }
    private string? color { get; set; }
    private int topSpeed { get; set; }

    public Car()
    {
    }

    public Car(Car car)
    {
        this.brands = car.brands;
        this.model = car.model;
        this.color = car.color;
        this.topSpeed = car.topSpeed;
    }

    public Car Clone()
    {
        return new Car(this);
    }
}
