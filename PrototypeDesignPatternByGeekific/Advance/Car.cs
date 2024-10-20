namespace PrototypeDesignPatternByGeekific;

public class Car : Vehicle
{
    private int _topSpeed;
    private GPSSystem? _gpsSystem;

    public Car() 
    {
    }

    public Car(Car car) : base(car)
    {
        this._topSpeed = car._topSpeed;
        //this._gpsSystem = car._gpsSystem; // Shallow Copy
        this._gpsSystem = new GPSSystem(); 
                        // or.gpsSystem.Clone(); // Deep Copy

    }
    public override Vehicle Clone()
    {
        return new Car(this);
    }
}
