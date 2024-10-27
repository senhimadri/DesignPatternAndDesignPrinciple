namespace AdopterDesignPatternByGFG;

public interface IPrinter
{
    void PrintDocument(string document);
}

public class LegacyPrinter
{
    public void OldPrint(string text)
    {
        Console.WriteLine($"Printing from LegacyPrinter: {text}");
    }
}


public class PrinterClassAdopter : LegacyPrinter, IPrinter
{
    public void PrintDocument(string document)
    {
        OldPrint(document);
    }
}

public class PrinterObjectAdopter : IPrinter
{
    LegacyPrinter printer = new LegacyPrinter();

    public void PrintDocument(string document)
    {
        printer.OldPrint(document);
    }
}

public class Client
{
    private readonly IPrinter _printer;

    public Client(IPrinter printer)
    {
        _printer = printer;
    }

    public void Print(string document)
    {
        _printer.PrintDocument(document);
    }
}