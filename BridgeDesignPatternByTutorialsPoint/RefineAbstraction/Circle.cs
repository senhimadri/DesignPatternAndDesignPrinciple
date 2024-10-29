using BridgeDesignPatternByTutorialsPoint.Abstraction;
using BridgeDesignPatternByTutorialsPoint.Implementer;

namespace BridgeDesignPatternByTutorialsPoint.RefineAbstraction;

public class Circle : Shape
{
    private int x, y, radius;

    public Circle(IDrawAPI drowAPI, int x, int y, int radius) : base(drowAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    public override void Drow()
    {
        drowAPI.DrowCircle(radius, x, y);
    }
}
