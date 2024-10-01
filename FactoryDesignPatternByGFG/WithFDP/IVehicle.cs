namespace FactoryDesignPatternByGFG.Services;

public interface IVehicle
{
    public void PrintVehicle();
}

public class TwoWheeler : IVehicle
{
    public void PrintVehicle()
    {
        Console.WriteLine("I am Two Wheeler.");
    }
}

public class FourWheeler : IVehicle
{
    public void PrintVehicle()
    {
        Console.WriteLine("I am Four Wheeler.");
    }
}

public interface IVehicleFactory
{
    IVehicle CreateVehicle();
}

public class TwoWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new TwoWheeler();
    }
}

public class FourWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new FourWheeler();
    }
}


public class Client
{
    private IVehicle pVehicle;

    public Client(IVehicleFactory factory)
    {
        pVehicle = factory.CreateVehicle();
    }

    public IVehicle GetVehicle()
    {
        return pVehicle;
    }
}

public class FactoryDesignPatternImplementation
{
    public static void Main()
    {
        IVehicleFactory twoWheelerFactory = new TwoWheelerFactory();
        Client twoWheelerClient = new Client(twoWheelerFactory);
        IVehicle twoWheeler = twoWheelerClient.GetVehicle();
        twoWheeler.PrintVehicle();


        IVehicleFactory fourWheelerFactory = new FourWheelerFactory();
        Client fourWheelerClient = new Client(fourWheelerFactory);
        IVehicle fourWheeler = twoWheelerClient.GetVehicle();
        fourWheeler.PrintVehicle();

    }
}
