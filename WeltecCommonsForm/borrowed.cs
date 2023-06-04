namespace WeltecCommonsForm
{
    internal class Borrowed : Catalogue
    {
        Person person;
        SortedDictionary<Catalogue, DateOnly> borrowedItem;

        public Person Person { get => person; set => person = value; }
        internal SortedDictionary<Catalogue, DateOnly> BorrowedItem { get => borrowedItem; set => borrowedItem = value; }

        public Borrowed(Person person, SortedDictionary<Catalogue, DateOnly> borrowedItem)
        {
            Person = person;
            BorrowedItem = borrowedItem;
        }

        public Borrowed() { }

    }
}
