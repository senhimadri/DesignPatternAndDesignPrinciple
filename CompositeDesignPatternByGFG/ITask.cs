namespace CompositeDesignPatternByGFG;

public interface ITask
{
    string GetTitle();
    void SetTitle(string title);
    void Display();
}

public class SimpleTask(string _title) : ITask
{
    private string title= _title;

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


public class TaskManagementApp
{
    public static void Main()
    {
        ITask simpleTask1 = new SimpleTask("Computer Coding.");
        ITask simpleTask2 = new SimpleTask("Writing Documentation.");

        TaskList projectTask = new TaskList("Project Task.");

        projectTask.AddTask(simpleTask1);
        projectTask.AddTask(simpleTask2);



        TaskList phase1Tasks = new TaskList("Phase1 Tasks");

        phase1Tasks.AddTask(new SimpleTask("Design."));
        phase1Tasks.AddTask(new SimpleTask("Implementation."));

        projectTask.AddTask(projectTask);

        projectTask.Display();
    }
}