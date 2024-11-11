using CommandDesignPatternByGfG.CommandInterface;
using CommandDesignPatternByGfG.Receiver;

namespace CommandDesignPatternByGfG.ConcreteCommandClasses;

public class AdjustVolumeCommand(Stereo stereo) : ICommand
{
    private Stereo stereo = stereo;
    public void Execute() => stereo.AdjustVolume();
}
