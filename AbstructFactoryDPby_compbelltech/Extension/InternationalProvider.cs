namespace AbstructFactoryDPby_compbelltech.Services;

public class InternationalProvider
{
    public static IInternationalFactory Create(Country country)
    {
        switch (country)
        {
            case Country.England:
                return new England();
            case Country.Spain:
                return new Spane();
            default:
                throw new NotSupportedException($"{country} is not currently supported.");
        }
    }
}
