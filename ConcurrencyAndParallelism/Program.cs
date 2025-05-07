// See https://aka.ms/new-console-template for more information
using ConcurrencyAndParallelism;


Console.WriteLine("Lagacy Code Run =====================");

LagacyCodeExample1 lagacy = new LagacyCodeExample1();
lagacy.LagacyRun();

Console.WriteLine("Lagacy Code Stop =====================");

await Task.Delay(2000);

Console.WriteLine("Refactor Code Run =====================");

RefactorCodeExample1 refactor = new RefactorCodeExample1();

await refactor.Run();

Console.WriteLine("Refactor Code Stop =====================");

Console.ReadLine();

