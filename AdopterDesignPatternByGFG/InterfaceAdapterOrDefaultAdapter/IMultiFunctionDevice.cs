namespace AdopterDesignPatternByGFG.InterfaceAdapterOrDefaultAdapter;

public interface IMultiFunctionDevice
{
    void Print(string document);
    void Scan(string document);
    void Copy(string document);
    void Fax(string document);
}


public abstract class MultiFunctionDeviceAdapter : IMultiFunctionDevice
{
    public virtual void Print(string document) { /* Default implementation */ }
    public virtual void Scan(string document) { /* Default implementation */ }
    public virtual void Copy(string document) { /* Default implementation */ }
    public virtual void Fax(string document) { /* Default implementation */ }
}

public class Printer : MultiFunctionDeviceAdapter
{
    public override void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");
    }
}

public class Scanner : MultiFunctionDeviceAdapter
{
    public override void Scan(string document)
    {
        Console.WriteLine($"Scanning document: {document}");
    }
}

class Client
{
    static void Main()
    {
        IMultiFunctionDevice printer = new Printer();
        printer.Print("Hello, Interface Adapter!");

        IMultiFunctionDevice scanner = new Scanner();
        scanner.Scan("Scanning this document.");
    }
}
