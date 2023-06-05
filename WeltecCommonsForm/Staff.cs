namespace WeltecCommonsForm
{
    internal class Staff : Person
    {
        string title;
        public string Title { get => title; set => title = value; }
        public Staff(string fName, string lName, int Id, DateTime dob, float fines, string title)
        {
            this.FName = fName;
            this.LName = lName;
            this.ID = Id;
            this.Dob = dob;
            this.Fines = fines;
            this.Title = title;
            this.BorrowedItems = new Dictionary<Catalogue, DateTime>();
        }

        

        public override int? GetBorrowLimit()
        {
            return null;
        }

    }
}
