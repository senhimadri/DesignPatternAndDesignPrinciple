namespace BridgeDesignPatternByTutorialsPoint;

public interface IDrawAPI
{
    public void DrowCircle(int redius, int x, int y);
}

public class RedCircle : IDrawAPI
{
    public void DrowCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Circle[ color: red, radius: {radius } , x: { x }, y: { y }");
    }
}


public class GreenCircle : IDrawAPI
{
    public void DrowCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Circle[ color: Green, radius: {radius} , x: {x}, y: {y}");
    }
}

public abstract class Shape
{
    protected IDrawAPI drowAPI;

    public Shape(IDrawAPI drowAPI) => this.drowAPI = drowAPI;


    public abstract void Drow();
}


public class Circle : Shape
{
    private int x, y, radius;

    public Circle(IDrawAPI drowAPI, int x, int y , int radius) : base(drowAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    public override void Drow()
    {
        drowAPI.DrowCircle(radius,x,y);
    }
}

public class BridgeDesignPattern
{
    public static void Main()
    {
        Shape redCircle = new Circle(new RedCircle(),100,100,250);
        Shape greenCircle = new Circle(new GreenCircle(), 200, 250, 300);

        redCircle.Drow();

        greenCircle.Drow();
    }
}