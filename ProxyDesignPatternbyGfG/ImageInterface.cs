namespace ProxyDesignPatternbyGfG;

public interface ImageInterface
{
    void Display();
}

public class RealImage : ImageInterface
{
    private string filename;
    public RealImage(string filename)
                                => this.filename = filename;

    public void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading image {filename}");
    }
    
    public void Display()
    {
        Console.WriteLine($"Displaying image {filename}");
    }
}

public class ProxyImage : ImageInterface
{
    private RealImage? realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage is null)
        {
            realImage = new RealImage(fileName);
        }

        realImage.Display();
    }
}

public class ProxyPatternImplementation
{
    public static void Main()
    {
        ImageInterface image = new ProxyImage("example.jpg");

        image.Display();

        image.Display();

    }
}


