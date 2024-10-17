using BuilderDesignPatternBySudoCODE.Builder;
using BuilderDesignPatternBySudoCODE.ConcreteBuilder;
using BuilderDesignPatternBySudoCODE.Director;
using BuilderDesignPatternBySudoCODE.Product;

namespace BuilderDesignPatternBySudoCODE.Client;

internal static class Implementation
{
    public static void Main()
    {
        IURLBuilder urlBuilder = new URLBuilder();

        URLDirector director = new URLDirector(urlBuilder);

        director.BuildSimpleURL();
        URL simpleUrl = urlBuilder.GetURL();
        Console.WriteLine($"Simple Url: {simpleUrl}" );

        director.BuildComplexURL();
        URL complexUrl = urlBuilder.GetURL();
        Console.WriteLine($"Complex Url: {complexUrl}");
    }
}
