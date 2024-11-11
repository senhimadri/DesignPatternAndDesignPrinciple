namespace CommandDesignPatternByGfG.Receiver;

public class Telivision : IDevice
{
    public void TurnOff() => Console.WriteLine("Telivision turned on.");
    public void TurnOn() => Console.WriteLine("Telivision turned off.");
    public void ChangeChannel() => Console.WriteLine("Channel changed.");
}
