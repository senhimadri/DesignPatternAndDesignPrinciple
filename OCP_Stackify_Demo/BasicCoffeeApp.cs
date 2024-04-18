namespace CoffeeMachine;

public class BasicCoffeeApp
{
    private BasicCoffeeMachine coffeeMachine;

    public BasicCoffeeApp(BasicCoffeeMachine _coffeeMachine)
    {
        coffeeMachine = _coffeeMachine;
    }

    public Coffee PrepareCoffee(CoffeeSelection selection)
    {
        Coffee coffee = this.coffeeMachine.BrewCoffee(selection);
        Console.WriteLine("Coffee is Ready.");
        return coffee;
    }
}
