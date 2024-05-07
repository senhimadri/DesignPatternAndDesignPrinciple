using ISP_ClassLibrary_IamTimCorey.OptimizedCode.GeneralInterface;

namespace ISP_ClassLibrary_IamTimCorey.OptimizedCode.Books;

public interface IBook : ILibraryItem
{
    public string Author { get; set; }
    public int Pages { get; set; }
}

