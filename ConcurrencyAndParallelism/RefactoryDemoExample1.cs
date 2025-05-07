namespace ConcurrencyAndParallelism;

public class LagacyCodeExample1
{

    public void LagacyRun()
    {
        Console.WriteLine("Starting................");

        var data1 = FetchData("Source 1");
        var data2 = FetchData("Source 2");
        var data3 = FetchData("Source 3");

        ProcessData(data1);
        ProcessData(data2);
        ProcessData(data3);

        Console.WriteLine("Done.");
    }


    private string FetchData(string sourse)
    {
        Console.WriteLine($"Fetching data from {sourse}.......");

        Thread.Sleep(2000);

        return $"Data from {sourse}......";
    }

    private void ProcessData(string data)
    {
        Console.WriteLine($"Processing {data}....................");

        for (int i = 0; i < 1_000_000; i++) ;

        Console.WriteLine($"Processed : {data} ================");

    }
}

public class RefactorCodeExample1
{

    public async Task Run()
    {
        Console.WriteLine("Starting................");

        var fetchTasks = new[]
        {
            FetchDataAsync("Source 1"),FetchDataAsync("Source 2"),FetchDataAsync("Source 3")
        };

        var dataResult = await Task.WhenAll(fetchTasks); // Concurrent

        Parallel.ForEach(dataResult,data=> ProcessData(data));

        Console.WriteLine("Done......................");
    }


    private async Task<string> FetchDataAsync(string sourse)
    {
        Console.WriteLine($"Fetching data from {sourse}.......");

        await Task.Delay(2000);

        return $"Data from {sourse}......";
    }

    private void ProcessData(string data)
    {
        Console.WriteLine($"Processing {data}....................");

        for (int i = 0; i < 1_000_000; i++) ;

        Console.WriteLine($"Processed : {data} ================");

    }
}
