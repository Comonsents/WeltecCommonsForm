namespace WeltecCommonsForm
{
    public abstract class Person
    {
        string fName;
        string lName;
        int id;
        DateTime dob;
        float fines;

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public int ID { get => id; set => id = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public float Fines { get => fines; set => fines = value; }

        public float GetFine()
        {
            return this.Fines;
        }
        public abstract int GetBorrowLimit();
    }
}
