namespace ISP_Demo_IAmTimCorey.OptimizedCode;

public interface IAudioBook : ILibraryItem
{
    public string Author { get; set; }
    public int RunTimeinMinutes { get; set; }
}
