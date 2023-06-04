namespace WeltecCommonsForm
{
    internal class borrowed : Catalogue
    {
        Person person;
        Catalogue borrowedItem;
        DateOnly? dateBorrowed;

        public Person Person { get => person; set => person = value; }
        internal Catalogue BorrowedItem { get => borrowedItem; set => borrowedItem = value; }
        public DateOnly? DateBorrowed { get => dateBorrowed; set => dateBorrowed = value; }

        public borrowed(Person person, Catalogue borrowedItem, DateOnly? dateBorrowed)
        {
            Person = person;
            BorrowedItem = borrowedItem;
            DateBorrowed = dateBorrowed;
        }

        public DateOnly GetDueDate()
        {
            DateOnly date = DateBorrowed.Value.AddDays(28);
            return date;
        }
    }
}
