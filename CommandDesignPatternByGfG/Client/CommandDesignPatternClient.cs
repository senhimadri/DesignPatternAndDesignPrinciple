using CommandDesignPatternByGfG.CommandInterface;
using CommandDesignPatternByGfG.ConcreteCommandClasses;
using CommandDesignPatternByGfG.Invoker;
using CommandDesignPatternByGfG.Receiver;

namespace CommandDesignPatternByGfG.Client;

public class CommandDesignPatternClient
{
    public static void Main()
    {
        Telivision telivision = new Telivision();
        Stereo stereo = new Stereo();

        ICommand turnOnTelivisionCommand = new TurnOnCommand(telivision);
        ICommand turnOffTelivisionCommand = new TurneOffCommand(telivision);
        ICommand changeChannelTelivisionCommand = new ChangeChannelCommand(telivision);


        ICommand turnOnStereoCommand = new TurnOnCommand(stereo);
        ICommand turnOffStereoCommand = new TurneOffCommand(stereo);
        ICommand adjuctVolumeStererCommand = new AdjustVolumeCommand(stereo);

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOnTelivisionCommand);
        remote.PressButton();

        remote.SetCommand(adjuctVolumeStererCommand);
        remote.PressButton();

        remote.SetCommand(changeChannelTelivisionCommand);
        remote.PressButton();

        remote.SetCommand(turnOffTelivisionCommand);
        remote.PressButton();
    }
}
