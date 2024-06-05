namespace AbstructFactoryDPby_compbelltech.Services;

public class Madrid : ICapitalCity
{
    public int GetPopulation()
    {
        return 700000;
    }
    public List<string> ListTopAttractions()
    {
        return new List<string>()
        {
            "Madrid 1", "Madrid 2", "Madrid 3"
        };
    }
}
