namespace WeltecCommonsForm
{
    internal class Borrowed : Catalogue
    {
        Person borrower;
        SortedDictionary<Catalogue, DateTime> borrowedItems;

        public Person Borrower { get => borrower; set => borrower = value; }
        internal SortedDictionary<Catalogue, DateTime> BorrowedItems { get => borrowedItems; set => borrowedItems = value; }

        public Borrowed(Person borrower, SortedDictionary<Catalogue, DateTime> borrowedItems)
        {
            Borrower = borrower;
            BorrowedItems = borrowedItems;
        }

        public Borrowed() 
        { 
            BorrowedItems = new SortedDictionary<Catalogue, DateTime>();
        }

    }
}
