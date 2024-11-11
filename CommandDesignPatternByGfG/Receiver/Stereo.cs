namespace CommandDesignPatternByGfG.Receiver;

public class Stereo : IDevice
{
    public void TurnOff() => Console.WriteLine("Stereo turned on.");
    public void TurnOn() => Console.WriteLine("Stereo turned off.");
    public void AdjustVolume() => Console.WriteLine("Volume adhusted.");
}
