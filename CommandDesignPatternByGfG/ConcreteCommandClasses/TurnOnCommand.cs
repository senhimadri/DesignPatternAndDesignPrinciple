using CommandDesignPatternByGfG.CommandInterface;
using CommandDesignPatternByGfG.Receiver;

namespace CommandDesignPatternByGfG.ConcreteCommandClasses;

public class TurnOnCommand(IDevice device) : ICommand
{
    private IDevice device = device;
    public void Execute()=> device.TurnOn();
}
