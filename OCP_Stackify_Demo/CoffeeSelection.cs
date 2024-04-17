namespace OCP_Stackify_Demo;

public class CoffeeSelection
{
    public static readonly CoffeeSelection FILTER_COFFEE = new CoffeeSelection("FILTER_COFFEE");

    private readonly string name;

    public CoffeeSelection(string _name)
    {
        name = _name;
    }

    public override string ToString()
    {
        return name;
    }
}

