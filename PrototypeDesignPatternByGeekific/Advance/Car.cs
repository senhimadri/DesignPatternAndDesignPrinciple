namespace PrototypeDesignPatternByGeekific;

public class Car : Vehicle
{
    private int topSpeed;
    private GPSSystem? gpsSystem;

    public Car(string? brand , string? model , string? color , int topSpeed ) : base( brand, model, color)
    {
        this.topSpeed = topSpeed;
        gpsSystem = new GPSSystem();
    }

    public Car(Car car) : base(car)
    {
        this.topSpeed = car.topSpeed;
        //this._gpsSystem = car._gpsSystem; // Shallow Copy
        this.gpsSystem = new GPSSystem(); 
                        // or.gpsSystem.Clone(); // Deep Copy

    }
    public override Vehicle Clone()
    {
        return new Car(this);
    }
}
