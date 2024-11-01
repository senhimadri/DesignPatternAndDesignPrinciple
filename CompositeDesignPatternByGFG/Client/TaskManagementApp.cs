using CompositeDesignPatternByGFG.Component;
using CompositeDesignPatternByGFG.Composite;
using CompositeDesignPatternByGFG.Leaf;

namespace CompositeDesignPatternByGFG.Client;

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