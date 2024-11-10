namespace ChainOfResponsibilityDesignPatternByGfG;

public interface ISupportHandler
{
    void HandleRequest(Request request);
    void SetNextHandler(ISupportHandler nextHandler);

}


public class Request(Priority _priority)
{
    private Priority priority = _priority;
    public Priority GetPriority() => priority;
}


public enum Priority
{
    Basic, Intermediate, Critical, Unhandles
}

public class Level1SupportHandler : ISupportHandler
{
    private ISupportHandler?   nextHandler;

    public void HandleRequest(Request request)
    {
        if (request.GetPriority() == Priority.Basic)
        {
            Console.WriteLine("Level 1 Support handle this issue.");
        }
        else  if(nextHandler is not null)
        {
            nextHandler.HandleRequest(request);
        }
    }
    public void SetNextHandler(ISupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }
}

public class Level2SupportHandler : ISupportHandler
{
    private ISupportHandler? nextHandler;

    public void HandleRequest(Request request)
    {
        if (request.GetPriority() == Priority.Intermediate)
        {
            Console.WriteLine("Level 2 Support handle this issue.");
        }
        else if (nextHandler is not null)
        {
            nextHandler.HandleRequest(request);
        }
    }
    public void SetNextHandler(ISupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }
}

public class Level3SupportHandler : ISupportHandler
{
    private ISupportHandler? nextHandler;

    public void HandleRequest(Request request)
    {
        if (request.GetPriority() == Priority.Critical)
        {
            Console.WriteLine("Level 3 Support handle this issue.");
        }
        else
        {
            Console.WriteLine("Request cannot be handled.");
        }
    }
    public void SetNextHandler(ISupportHandler nextHandler)
    {
        Console.WriteLine("This is the Last Level.");
    }
}



public class ChainOfResponsibilityClient
{
    public static void Main()
    {
        ISupportHandler level1SupportHandler = new Level1SupportHandler();
        ISupportHandler level2SupportHandler = new Level2SupportHandler();
        ISupportHandler level3SupportHandler = new Level3SupportHandler();

        level1SupportHandler.SetNextHandler(level2SupportHandler);
        level2SupportHandler.SetNextHandler(level3SupportHandler);

        Request request1 = new Request(Priority.Basic);
        Request request2 = new Request(Priority.Intermediate);
        Request request3 = new Request(Priority.Critical);
        Request request4 = new Request(Priority.Unhandles);

        level1SupportHandler.HandleRequest(request1);
        level1SupportHandler.HandleRequest(request2);
        level1SupportHandler.HandleRequest(request3);
        level1SupportHandler.HandleRequest(request4);

    }
}