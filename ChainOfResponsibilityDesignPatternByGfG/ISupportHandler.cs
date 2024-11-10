namespace ChainOfResponsibilityDesignPatternByGfG;

public interface ISupportHandler
{
    void HandleRequest();
    void SetNextHandler();

}


public class Request(Priority _priority)
{
    private Priority priority = _priority;
    public Priority GetPriority() => priority;
}


public enum Priority
{
    Basic, Intermediate, Critical
}

