﻿namespace CoffeeMachine;

public class BrewingUnit
{
    public Coffee Brew(CoffeeSelection selection, GroundCoffee groundCoffee,int waterAmount)
    {
        return new Coffee(selection,groundCoffee,waterAmount);
    }
}
