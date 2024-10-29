using BridgeDesignPatternByTutorialsPoint.Implementer;

namespace BridgeDesignPatternByTutorialsPoint.ConcreteImplementation;

public class GreenCircle : IDrawAPI
{
    public void DrowCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing Circle[ color: Green, radius: {radius} , x: {x}, y: {y}");
    }
}
