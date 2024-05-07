namespace ISP_Demo_IAmTimCorey.OrginalCode;

internal interface ILibraryItem
{
    public string Author { get; set; }
    public DateTime BorrowDate { get; set; }
    public string Borrower { get; set; }
    public int  CheckOutDurationInDays { get; set; }
    public string LibraryId { get; set; }
    public int Pages { get; set; }
    public string Title { get; set; }

    void CheckIn();

    void CheckOut(string borrower);

    DateTime GetDueTime();
}

