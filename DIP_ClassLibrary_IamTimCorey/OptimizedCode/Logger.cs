namespace DIP_ClassLibrary_IamTimCorey.OptimizedCode;

public class Logger : ILogger
{
    public void Log(string looger)
    {
        Console.WriteLine($"{looger}");
    }
}

