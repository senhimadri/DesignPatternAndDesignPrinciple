using ISP_ClassLibrary_IamTimCorey.OptimizedCode.Books;

namespace ISP_ClassLibrary_IamTimCorey.OrginalCode;

public class ReferenceBook :IBook
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
}

