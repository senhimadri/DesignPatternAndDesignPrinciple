using ISP_ClassLibrary_IamTimCorey.OptimizedCode.GeneralInterface;

namespace ISP_ClassLibrary_IamTimCorey.OptimizedCode.AudioBook;

public interface IAudioBook : ILibraryItem
{
    public string Author { get; set; }
    public int RunTimeinMinutes { get; set; }
}
