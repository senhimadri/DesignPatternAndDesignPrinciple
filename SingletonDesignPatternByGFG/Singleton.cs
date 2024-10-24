namespace SingletonDesignPatternByGFG.PrivateConstructor;

public class Singleton
{
	private static Singleton? instance;

	int counter = 0;
	private Singleton()
	{
		Console.WriteLine("Singleton is Instantiated."); ;
	}

	public static Singleton GetInstance()
	{
		if (instance is null)
			instance = new Singleton();

		return instance;
	}

	public void DoSomething()
	{
        counter++;
		Console.WriteLine(counter);
	}
}

public class NonSingleton
{

    int counter = 0;

    public void DoSomething()
    {
        counter++;
        Console.WriteLine(counter);
    }
}
