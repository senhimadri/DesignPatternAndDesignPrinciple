using ISP_ClassLibrary_IamTimCorey.OptimizedCode.GeneralInterface;

namespace ISP_ClassLibrary_IamTimCorey.OptimizedCode.Dvd;

public interface IDvd : ILibraryItem
{
    public List<string> Actors { get; set; }
    public int RunTimeInMinutes { get; set; }
}
