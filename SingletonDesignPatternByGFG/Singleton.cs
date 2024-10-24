namespace SingletonDesignPatternByGFG.PrivateConstructor;

public class Singleton
{
	private static Singleton? instance;
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
		Console.WriteLine("Something is Done.");
	}
}
