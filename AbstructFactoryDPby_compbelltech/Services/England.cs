namespace AbstructFactoryDPby_compbelltech.Services;

public class England : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new London();
    }

    public ILanguege CreateLanguege()
    {
        return new English();
    }
}
