namespace CompositeDesignPaternExercise;


//Component
public abstract class FileSystemItem(string name)
{
    public string Name { get; set; } = name;
    public abstract void Display(int depth);
}

// Leaf 
public class File(string name) : FileSystemItem(name)
{
    public override void Display(int depth) => Console.WriteLine(new string('-', depth) + Name);
}

public class Directory(string name) : FileSystemItem(name)
{
    private readonly List<FileSystemItem> items = new();
    public void Add(FileSystemItem item) => items.Add(item);
    public void Remove(FileSystemItem item) => items.Remove(item);

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
        items.ForEach(item=> item.Display(depth + 2));
    }
}

public static class FileSystemService
{

    public static void Main()
    {
        var root = new Directory("Root");
        var file1 = new File("File1.txt");
        var file2 = new File("File2.txt");
        var subDir = new Directory("SubDirectory");
        var file3 = new File("File3.txt");

        root.Add(file1);
        root.Add(subDir);
        subDir.Add(file2);
        subDir.Add(file3);

        root.Display(1);
    }
}

