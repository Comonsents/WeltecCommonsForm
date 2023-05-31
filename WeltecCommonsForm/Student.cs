namespace WeltecCommonsForm
{
    internal class Student : Person
    {
        public Student()
        {
        }

        public override int GetBorrowLimit()
        {
            return 5;
        }

    }
}
