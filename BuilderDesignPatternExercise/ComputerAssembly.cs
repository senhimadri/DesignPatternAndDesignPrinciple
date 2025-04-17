namespace BuilderDesignPatternExercise;

//1.Product
public class Computer
{
    private string? cpu;
    private string? ram;
    private string? storage;

    public void SetCpu(string cpu) => this.cpu = cpu;
    public void SetRam(string ram) => this.ram = ram;
    public void SetStorage(string storage) => this.storage = storage;

    public void DisplayInfo()
    {
        Console.WriteLine("Computer Configuration:");
        Console.WriteLine($"CPU : {cpu}");
        Console.WriteLine($"RAM : {ram}");
        Console.WriteLine($"Storage : {storage}");
    }
}
    
//2.Builder
public interface Builder
{
	void BuildCpu();
	void BuildRam();
	void BuildStorage();
    Computer GetResult();
}

//3.ConcreteBuilder
public class GamingComputerBuilder : Builder
{
    private Computer computer;
    public GamingComputerBuilder()=> this.computer = new Computer();
    public void BuildCpu() => computer.SetCpu("Gaming CPU");
    public void BuildRam() => computer.SetRam("16GB DDR4");
    public void BuildStorage() => computer.SetStorage("1TB SSD");
    public Computer GetResult() => computer;
}

//4.Director
public class ComputerDirector
{
    public void Construct(Builder builder)
    {
        builder.BuildCpu();
        builder.BuildRam();
        builder.BuildStorage();
    }
}

//5.	Client
public class Client
{
    public static void Main()
    {
        GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector();
        director.Construct(gamingComputerBuilder);
        Computer gamingComputer = gamingComputerBuilder.GetResult();
        gamingComputer.DisplayInfo();
    }
}

