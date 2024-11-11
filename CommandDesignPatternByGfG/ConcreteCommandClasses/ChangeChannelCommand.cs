using CommandDesignPatternByGfG.CommandInterface;
using CommandDesignPatternByGfG.Receiver;

namespace CommandDesignPatternByGfG.ConcreteCommandClasses;

public class ChangeChannelCommand(Telivision television) : ICommand
{
    private Telivision television = television;
    public void Execute() => television.ChangeChannel();
}
