namespace WeltecCommonsForm
{
    internal class Student : Person
    {
        public Student(string fName, string lName, int Id, DateTime dob, float fines)
        {
            this.FName = fName;
            this.LName = lName;
            this.ID = Id;
            this.Dob = dob;
            this.Fines = fines;
        }

        public override int? GetBorrowLimit()
        {
            return 5;
        }

    }
}
