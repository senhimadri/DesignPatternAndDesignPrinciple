namespace AdopterDesignPatternByGFG.TwoWayAdapterExample;

public interface IPrinter
{
    void PrintDocument(string document);
}


public interface ILegacyPrinter
{
    void OldPrint(string text);
}


public class LegacyPrinter : ILegacyPrinter
{
    public void OldPrint(string text)
    {
        Console.WriteLine($"Printing from LegacyPrinter: {text}");
    }
}


public class NewPrinter : IPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"Printing from NewPrinter: {document}");
    }
}

public class TwoWayPrinterAdapter : IPrinter, ILegacyPrinter
{
    private readonly LegacyPrinter? _legacyPrinter;
    private readonly NewPrinter? _newPrinter;

    public TwoWayPrinterAdapter(LegacyPrinter legacyPrinter)
    {
        _legacyPrinter = legacyPrinter;
    }

    public TwoWayPrinterAdapter(NewPrinter newPrinter)
    {
        _newPrinter = newPrinter;
    }

    // Implementing IPrinter for the client
    public void PrintDocument(string document)
    {
        if (_legacyPrinter != null)
        {
            // Adapt the call to the legacy printer
            _legacyPrinter.OldPrint(document);
        }
        else if (_newPrinter != null)
        {
            // Use the new printer directly
            _newPrinter.PrintDocument(document);
        }
    }

    // Implementing ILegacyPrinter for the legacy system
    public void OldPrint(string text)
    {
        if (_newPrinter != null)
        {
            // Adapt the call to the new printer
            _newPrinter.PrintDocument(text);
        }
        else if (_legacyPrinter != null)
        {
            // Use the legacy printer directly
            _legacyPrinter.OldPrint(text);
        }
    }
}