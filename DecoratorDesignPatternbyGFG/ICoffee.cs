namespace DecoratorDesignPatternbyGFG;

public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class PlainCoffee : ICoffee
{
    public double GetCost()
    {
        return 2.0;
    }
    public string GetDescription()
    {
        return "Plain Coffee";
    }
}

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee decoratorCoffee;

    public CoffeeDecorator(ICoffee _decoratorCoffee) => decoratorCoffee = _decoratorCoffee;


    public virtual double GetCost()
    {
        return decoratorCoffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return decoratorCoffee.GetDescription();
    }
}



public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}


public class SugerDecorator : CoffeeDecorator
{
    public SugerDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "Suger";
    }

    public override double GetCost()
    {
        return base.GetCost() + .2;
    }
}

public class DecoratorImplementation
{
    public static void Main()
    {
        ICoffee coffee = new PlainCoffee();

        Console.WriteLine($"Coffee Des:{coffee.GetDescription()}");
        Console.WriteLine($"Coffee Prc:{coffee.GetCost()}");

        ICoffee milkCoffee = new MilkDecorator(coffee);

        Console.WriteLine($"Coffee Des:{milkCoffee.GetDescription()}");
        Console.WriteLine($"Coffee Prc:{milkCoffee.GetCost()}");

        ICoffee sugerCoffee = new SugerDecorator(coffee);

        Console.WriteLine($"Coffee Des:{sugerCoffee.GetDescription()}");
        Console.WriteLine($"Coffee Prc:{sugerCoffee.GetCost()}");

    }
}


