namespace FactoryDesignPatternByGFG.WithoutFDP;

public interface IVehicles
{
    public void PrintVehicle();
}

public class TwoWheeler : IVehicles
{
    public void PrintVehicle()
    {
        Console.WriteLine("I am Two Wheeler.");
    }
}

public class FourWheeler : IVehicles
{
    public void PrintVehicle()
    {
        Console.WriteLine("I am Four Wheeler.");
    }
}

public enum VehiclesType
{
    TwoWheeler, FourWheeler
}
public class Client
{
    private IVehicles pVehicles;

    public Client(VehiclesType type)
    {
        switch (type)
        {
            case VehiclesType.TwoWheeler:
                pVehicles = new TwoWheeler();
                break;
            case VehiclesType.FourWheeler:
                pVehicles = new FourWheeler();
                break;
            default:
                throw new NotSupportedException($"{type} is not supported");
        }
    }

    public IVehicles GetVehicle()
    {
        return pVehicles;
    }
}

public class ImplementationCodeWithoutFDP
{
    public static void Main()
    {
        Client pClient = new Client(VehiclesType.TwoWheeler);

        IVehicles pvehicle = pClient.GetVehicle();

        pvehicle.PrintVehicle();
    }
}
