using BridgeDesignPatternByTutorialsPoint.Implementer;

namespace BridgeDesignPatternByTutorialsPoint.Abstraction;

public abstract class Shape
{
    protected IDrawAPI drowAPI;

    public Shape(IDrawAPI drowAPI) => this.drowAPI = drowAPI;


    public abstract void Drow();
}
