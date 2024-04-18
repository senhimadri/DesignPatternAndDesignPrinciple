namespace CoffeeMachine;

public class BasicCoffeeMachine
{

    private Dictionary<CoffeeSelection, Configuration> configMap;
    private Dictionary<CoffeeSelection, GroundCoffee> groundCoffee;
    private BrewingUnit brewingUnit;

    public BasicCoffeeMachine(Dictionary<CoffeeSelection,GroundCoffee> coffee)
    {
        this.groundCoffee = coffee;
        this.brewingUnit = new BrewingUnit();

        this.configMap = new Dictionary<CoffeeSelection, Configuration>();
        this.configMap.Add(CoffeeSelection.FILTER_COFFEE, new Configuration(30, 480));
    }

    public Coffee BrewCoffee(CoffeeSelection selection)
    {
        Configuration config = configMap[selection];
        GroundCoffee groundCoffee = this.groundCoffee[selection];
        return this.brewingUnit.Brew(selection, groundCoffee, config.GetQuantityWater());
    }

    public void AddGroundCoffee(CoffeeSelection sel, GroundCoffee newCoffee)
    {
        if (groundCoffee.ContainsKey(sel))
        {
            GroundCoffee existingCoffee = groundCoffee[sel];

            if (existingCoffee.GetName().Equals(newCoffee.GetName()))
            {
                existingCoffee.SetQuantity(existingCoffee.GetQuantity() + newCoffee.GetQuantity());
            }
            else
            {
                throw new CoffeeException("Only one kind of coffee supported for each CoffeeSelection.");
            }
        }
        else
        {
            groundCoffee.Add(sel, newCoffee);
        }
    }

}
