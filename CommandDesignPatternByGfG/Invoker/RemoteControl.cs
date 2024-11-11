using CommandDesignPatternByGfG.CommandInterface;

namespace CommandDesignPatternByGfG.Invoker;

public class RemoteControl
{
    private ICommand? command;
    public void SetCommand(ICommand command) => this.command = command;

    public void PressButton()
    {
        if (command is null)
            Console.WriteLine("Please set a command");
        else
            command.Execute();
    }
}
