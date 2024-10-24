// See https://aka.ms/new-console-template for more information
using SingletonDesignPatternByGFG.PrivateConstructor;

Singleton.GetInstance().DoSomething();

NonSingleton aa = new NonSingleton();
aa.DoSomething();

Console.ReadLine();