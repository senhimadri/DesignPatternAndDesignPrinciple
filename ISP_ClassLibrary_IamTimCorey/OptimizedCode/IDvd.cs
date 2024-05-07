namespace ISP_Demo_IAmTimCorey.OptimizedCode;

public interface IDvd : ILibraryItem
{
    public List<string> Actors { get; set; }
    public int RunTimeInMinutes { get; set; }
}
