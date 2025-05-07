namespace FlyweightDesignPatternByGfG;

public interface IIcon
{
    void Dwor(int x, int y);
}

public class FileIcon : IIcon
{
    private readonly string type;
    private readonly Image image;    

    public FileIcon(string type, Image image)
    {
        this.type = type;
        this.image = image;
    }
    public void Dwor(int x, int y)
    {
        Console.WriteLine($"Dworing {type} icon at position {x} and {y}.");
    }
}

public class FolderIcon : IIcon
{
    private string color;
    private Image image;    

    public FolderIcon(string color, Image image)
    {
        this.color = color;
        this.image = image;
    }
    public void Dwor(int x, int y)
    {
        Console.WriteLine($"Drawing folder icon with color {color} at position { x} and { y } ");
    }

}

public class IconFactory
{
    private Dictionary<string, IIcon> iconCache = new Dictionary<string, IIcon>();

    public IIcon GetIcon(string key)
    {
        if (iconCache.ContainsKey(key))
        {
            return iconCache[key];
        }
        else
        {
            IIcon icon;

            if (key.Equals("file"))
            {
                icon = new FileIcon("pdf", LoadImage("Icon"));
            }
            else if(key.Equals("folder"))
            {
                icon = new FolderIcon("green", LoadImage("Folder"));
            }
            else
            {
                throw new Exception();
            }

            iconCache.Add(key, icon);
            return icon;
        }
    }

    private Image LoadImage(string filename)
    {
        return new Image(filename);
    }
}

public class NewClass
{
    public string? Name { get; set; }
    public string? StaaticString { get; set; }

}

public class Client
{
    public static void Main()
    {
        IconFactory iconFactory = new IconFactory();

        IIcon icon1 = iconFactory.GetIcon("file");
        icon1.Dwor(5,6);

        IIcon icon2 = iconFactory.GetIcon("folder");
        icon2.Dwor(9, 0);

        IIcon icon3 = iconFactory.GetIcon("file");
        icon3.Dwor(5, 6);

        IIcon icon4 = iconFactory.GetIcon("folder");
        icon4.Dwor(9, 0);

    }
}


public class Image
{
    public Image(string name)
    {
        Console.WriteLine($"Image Type Created : {name}");
    }
}
