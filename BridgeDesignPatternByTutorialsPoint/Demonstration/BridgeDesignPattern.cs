using BridgeDesignPatternByTutorialsPoint.Abstraction;
using BridgeDesignPatternByTutorialsPoint.ConcreteImplementation;
using BridgeDesignPatternByTutorialsPoint.RefineAbstraction;

namespace BridgeDesignPatternByTutorialsPoint.Demonstration;

public class BridgeDesignPattern
{
    public static void Main()
    {
        Shape redCircle = new Circle(new RedCircle(), 100, 100, 250);
        Shape greenCircle = new Circle(new GreenCircle(), 200, 250, 300);

        redCircle.Drow();

        greenCircle.Drow();
    }
}