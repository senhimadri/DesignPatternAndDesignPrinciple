using OCP_Stackify_Demo;

Dictionary<CoffeeSelection, GroundCoffee> beans = new Dictionary<CoffeeSelection, GroundCoffee>();
beans.Add(CoffeeSelection.FILTER_COFFEE, new GroundCoffee("My Favorite coffee bean", 100));

BasicCoffeeMachine machine = new BasicCoffeeMachine(beans);

BasicCoffeeApp app = new BasicCoffeeApp(machine);

try
{
    app.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
}
catch (CoffeeException e)
{
    Console.WriteLine(e.Message);
}
