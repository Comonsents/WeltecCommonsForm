namespace WeltecCommonsForm
{
    internal class Student : Person
    {
        public Student(string fName, string lName, int Id, DateTime dob, float fines, Image profilePicture)
        {
            this.FName = fName;
            this.LName = lName;
            this.ID = Id;
            this.Dob = dob;
            this.Fines = fines;
            this.ProfilePicture = profilePicture;
            this.BorrowedItems = new Dictionary<Catalogue, DateTime>();
        }

        public override int? GetBorrowLimit()
        {
            return 5;
        }

    }
}
