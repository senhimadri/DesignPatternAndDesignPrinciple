namespace AbstructFactoryDPby_compbelltech.Services;

public class Spane : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new Madrid();
    }

    public ILanguege CreateLanguege()
    {
        return new Spanish();
    }
}
