namespace FecadeDesignPatternByGfG;


public interface IHotel
{
    public Menus GetMenus();
}


public class NonVegRestaurant : IHotel
{
    public Menus GetMenus()
    {
        NonVegMenu nv = new NonVegMenu();
        return nv;
    }
}

public class VegRestaurant : IHotel
{
    public Menus GetMenus()
    {
        VegMenu vm = new VegMenu();
        return vm;
    }
}


public class VegNonVegBothResturant : IHotel
{
    public Menus GetMenus()
    {
        BothMenu bm = new BothMenu();
        return bm;
    }
}


//Fecade 
public interface IHotelKeeper
{
    VegMenu GetVegMenu();
    NonVegMenu GetNonVegMenu();
    BothMenu GetVegNonVegMenu();
}



public class HotelKeeperImplementation : IHotelKeeper
{
    public VegMenu GetVegMenu()
    {
        VegRestaurant vegRestaurant = new VegRestaurant();
        VegMenu vegMenu = (VegMenu)vegRestaurant.GetMenus();

        return vegMenu;
    }
    public NonVegMenu GetNonVegMenu()
    {
        NonVegRestaurant nonVegRestaurant = new NonVegRestaurant();
        NonVegMenu nonVegMenu = (NonVegMenu)nonVegRestaurant.GetMenus();
        return nonVegMenu;
    }
    public BothMenu GetVegNonVegMenu()
    {
        VegNonVegBothResturant bothRestaurant = new VegNonVegBothResturant();
        BothMenu bothMenu = (BothMenu)bothRestaurant.GetMenus();
        return bothMenu;
    }
}


public class Client
{
    public static void Main()
    {
        IHotelKeeper hotelKeeper = new HotelKeeperImplementation();

        VegMenu vegMenu = hotelKeeper.GetVegMenu();
        NonVegMenu nonVegMenu = hotelKeeper.GetNonVegMenu();
        BothMenu bothMenu = hotelKeeper.GetVegNonVegMenu();


    }
}

public class Menus
{

}
public class VegMenu : Menus
{
    public VegMenu()
    {
        Console.WriteLine("Veg Menu Created.");
    }
}
public class NonVegMenu : Menus
{
    public NonVegMenu()
    {
        Console.WriteLine("NoVeg Menu Created.");
    }
}

public class BothMenu : Menus
{
    public BothMenu()
    {
        Console.WriteLine("Both Veg and NonVeg Menu is created.");
    }
}
