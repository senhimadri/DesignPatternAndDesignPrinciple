namespace AbstructFactoryDPby_compbelltech.Services;

public class London : ICapitalCity
{
    public int GetPopulation()
    {
        return 600000;
    }
    public List<string> ListTopAttractions()
    {
        return new List<string>()
        {
            "London 1", "London 2", "London 3"
        };
    }
}
