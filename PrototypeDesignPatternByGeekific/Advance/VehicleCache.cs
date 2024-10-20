namespace PrototypeDesignPatternByGeekific.Advance;

internal class VehicleCache
{
    private Dictionary<string, Vehicle> cache = new Dictionary<string, Vehicle>();

	public VehicleCache()
	{
		Car car = new Car(brand: "Bugatti",model: "M21", color: "Black", topSpeed: 300);
        Bus bus = new Bus(brand: "Volvo", model: "XL34567", color: "White", doors: 3);

        cache.Add("Bugatti",car);
        cache.Add("Volvo", bus);
    }


    public Vehicle GetClone(string key)
    {
        return cache[key].Clone();
    }
}
