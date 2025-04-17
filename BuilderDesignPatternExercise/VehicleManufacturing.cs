namespace BuilderDesignPatternExercise;

public class Vehicle
{
    public string? VehicleType { get; set; }
    public string? Frame { get; set; }
    public string? Engine { get; set; }
    public int Wheel { get; set; }
    public int Doors { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Type :{ VehicleType }");
        Console.WriteLine($"Frame :{ Frame }");
        Console.WriteLine($"Engine :{ Engine }");
        Console.WriteLine($"Number of Wheel:{Wheel}");
        Console.WriteLine($"Number of Doors:{Doors}");
    }
}

public interface IVehicleBuilder
{
    void BuildFrame();
    void BuildEngine();
    void BuildWheel();
    void BuildDoor();

    Vehicle GetVehicle();
}

public class CarBuilder : IVehicleBuilder
{
    private Vehicle _vehicle = new Vehicle();
    public CarBuilder() => _vehicle.VehicleType = "Car";

    public void BuildFrame() => _vehicle.Frame = "Car Frame";
    public void BuildEngine() => _vehicle.Engine = "2500 CC";
    public void BuildWheel() => _vehicle.Wheel = 4;
    public void BuildDoor() => _vehicle.Doors = 4;

    public Vehicle GetVehicle() => _vehicle;
}

public class MotorcycleBuilder : IVehicleBuilder
{
    private Vehicle _vehicle = new Vehicle();
    public MotorcycleBuilder() => _vehicle.VehicleType = "Motorcycle";

    public void BuildFrame() => _vehicle.Frame = "Motorcycle Frame";
    public void BuildEngine() => _vehicle.Engine = "350 CC";
    public void BuildWheel() => _vehicle.Wheel = 2;
    public void BuildDoor() => _vehicle.Doors = 0;
    public Vehicle GetVehicle() => _vehicle;
}

public class TruckBuilder : IVehicleBuilder
{
    private Vehicle _vehicle = new Vehicle();
    public TruckBuilder() => _vehicle.VehicleType = "Truck";

    public void BuildFrame() => _vehicle.Frame = "Truck Frame";
    public void BuildEngine() => _vehicle.Engine = "5000 CC";
    public void BuildWheel() => _vehicle.Wheel = 4;
    public void BuildDoor() => _vehicle.Doors = 2;
    public Vehicle GetVehicle() => _vehicle;
}


public class VehicleDirector
{
    public void Construct(IVehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildDoor();
        vehicleBuilder.BuildWheel();
    }
}


public static class VehicleManufacturingClient
{
    public static void Main()
    {
        var director = new VehicleDirector();

        IVehicleBuilder carBuilder = new CarBuilder();
        director.Construct(carBuilder);
        Vehicle car = carBuilder.GetVehicle();
        car.DisplayInfo();

        IVehicleBuilder motorCycleBuilder = new MotorcycleBuilder();
        director.Construct(motorCycleBuilder);
        Vehicle motorCycle = motorCycleBuilder.GetVehicle();
        motorCycle.DisplayInfo();

    }
}

