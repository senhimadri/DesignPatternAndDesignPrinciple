using CompositeDesignPatternByGFG.Component;

namespace CompositeDesignPatternByGFG.Composite;

public class TaskList : ITask
{
    private string title;
    private List<ITask> tasks;

    public TaskList(string _title)
    {
        title = _title;
        tasks = new List<ITask>();
    }

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

        foreach (var task in tasks)
        {
            task.Display();
        }
    }

    public void AddTask(ITask task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(ITask task)
    {
        tasks.Remove(task);
    }
}
