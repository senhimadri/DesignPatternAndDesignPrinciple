namespace DecoratorDesignPatternExercise;

// Component Interface
public interface IWeapon
{
    int GetDamage();
    string GetDescription();
}

// Concrete Component
public class Pistol : IWeapon
{
    public int GetDamage() => 10;
    public string GetDescription() => "Pistol";
}

// Decorator Abstract Class 
public abstract class WeaponDecorator(IWeapon weapon) : IWeapon
{
    protected IWeapon _weapon = weapon;
    public virtual int GetDamage() => _weapon.GetDamage();
    public virtual string GetDescription() => _weapon.GetDescription();
}

// Concrete Decorator
public class Scope(IWeapon weapon) : WeaponDecorator(weapon)
{
    public override int GetDamage() => _weapon.GetDamage() + 5;
    public override string GetDescription() => $"{_weapon.GetDescription()} with Sope";
}

public class ExtendedMagazine(IWeapon weapon) : WeaponDecorator(weapon)
{
    public override string GetDescription() => $"{_weapon.GetDescription()} with Extended Magazine";
}


internal static class WeaponEnhancementService
{
    public static void Main()
    {
        IWeapon pistol = new Pistol();
        Console.WriteLine($"{pistol.GetDescription()} deals {pistol.GetDamage()} damage.");

        pistol = new Scope(pistol);
        Console.WriteLine($"{pistol.GetDescription()} deals {pistol.GetDamage()} damage.");

        pistol = new ExtendedMagazine(pistol);
        Console.WriteLine($"{pistol.GetDescription()} deals {pistol.GetDamage()} damage.");
    }
}
