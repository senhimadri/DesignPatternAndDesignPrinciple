namespace OCP_Stackify_Demo;

public class Coffee
{
    private CoffeeSelection selection;
    private GroundCoffee groundCoffee;
    private int waterAmount;

    public Coffee(CoffeeSelection _selection, GroundCoffee _groundCoffee, int _waterAmount)
    {
        selection = _selection;
        groundCoffee = _groundCoffee;
        waterAmount = _waterAmount;
    }

    public override string ToString()
    {
        return "Coffee brewed: " + selection.ToString();
    }
}