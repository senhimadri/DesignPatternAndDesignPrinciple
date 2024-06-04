namespace FactoryPatternWebAPIByIAmTimCorey.Sample;

public class Sample1: ISample1
{
    public string CurrentDateTime { get; set; } = DateTime.Now.ToString();
}

public interface ISample1
{
    string CurrentDateTime { get; set; }
}


