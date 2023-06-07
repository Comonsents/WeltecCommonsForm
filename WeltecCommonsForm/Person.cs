namespace WeltecCommonsForm
{
    internal abstract class Person
    {
        string fName;
        string lName;
        int id;
        DateTime dob;
        float fines;
        string fullName;
        Image profilePicture;
        Dictionary<Catalogue, DateTime> borrowedItems;
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public int ID { get => id; set => id = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public float Fines { get => fines; set => fines = value; }
        public string FullName => $"{fName} {lName}";
        public Dictionary<Catalogue, DateTime> BorrowedItems { get => borrowedItems; set => borrowedItems = value; }
        public Image ProfilePicture { get => profilePicture; set => profilePicture = value; }

        public float GetFine()
        {
            float fine = 0;
            foreach(KeyValuePair<Catalogue, DateTime> kvp in borrowedItems)
            {
                Catalogue borrowedItem = kvp.Key;
                DateTime dueDate = kvp.Value;

                if (DateTime.Now > dueDate)
                {
                    TimeSpan overdueAmount = DateTime.Now - dueDate;
                    int daysOverdue = overdueAmount.Days;
                    float itemFine = daysOverdue * 5;

                    fine += itemFine;
                }
            }
            return fine;
        }
        public abstract int? GetBorrowLimit();
    }
}
