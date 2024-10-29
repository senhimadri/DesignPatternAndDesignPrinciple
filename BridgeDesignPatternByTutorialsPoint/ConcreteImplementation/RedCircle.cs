using BridgeDesignPatternByTutorialsPoint.Implementer;

namespace BridgeDesignPatternByTutorialsPoint.ConcreteImplementation;

public class RedCircle : IDrawAPI
{
    public void DrowCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Circle[ color: red, radius: {radius} , x: {x}, y: {y}");
    }
}
