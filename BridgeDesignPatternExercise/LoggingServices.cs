using System;

namespace BridgeDesignPatternExercise;

public interface ILogDestination
{
    void Write(string formattedMessage);
}

public class ConsoleDestination : ILogDestination
{
    public void Write(string formattedMessage)
    {
        Console.WriteLine($"Write Log : {formattedMessage}");
    }
}

public class FileDestination(string filePath) : ILogDestination
{
    public void Write(string formattedMessage)
    {
        Console.WriteLine($"Select Or create of File Path : {filePath}");
        Console.WriteLine($"Write Log : {formattedMessage}");
        throw new NotImplementedException();
    }
}

public class ElasticSearchDestination(string connectionString) : ILogDestination
{
    public void Write(string formattedMessage)
    {
        Console.WriteLine($"Open Connection  {connectionString}");
        Console.WriteLine($"Write Log : {formattedMessage}");
        Console.WriteLine($"Colse Connection  {connectionString}");
    }
}

public  abstract class Logger(ILogDestination logDestination)
{
    protected ILogDestination _logDestination = logDestination;
    public abstract void Log(string message);
}

public class SimpleLogger(ILogDestination logDestination) : Logger(logDestination)
{
    public override void Log(string message)
    {
        string formattedMessage = $"Created At :{DateTime.Now} , Message: {message}";
        _logDestination.Write(formattedMessage);
    }
}

public class DetailedLogger(ILogDestination logDestination) : Logger(logDestination)
{
    public override void Log(string message)
    {
        string formattedMessage = $"Created at : {DateTime.Now} , [Thread:{Thread.CurrentThread.ManagedThreadId}] , Message : {message}";
        _logDestination.Write(formattedMessage);
    }
}


public static class LoggingServiceImplementation
{

    public static void Main()
    {
        string logMessage = "new log message that retrive from system";

        ILogDestination elasticSearchDestination = new ElasticSearchDestination("ConnectionString: ElasticSearch");

        Logger simpleLogger = new SimpleLogger(elasticSearchDestination);
        simpleLogger.Log(logMessage);

        Logger detailedLogger = new DetailedLogger(elasticSearchDestination);
        detailedLogger.Log(logMessage);

        Console.ReadLine();

    }
}

