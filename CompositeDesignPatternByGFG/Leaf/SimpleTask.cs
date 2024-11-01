using CompositeDesignPatternByGFG.Component;

namespace CompositeDesignPatternByGFG.Leaf;

public class SimpleTask(string _title) : ITask
{
    private string title = _title;

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void Display()
    {
        Console.WriteLine($"Simple task {title}");
    }
}
