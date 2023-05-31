namespace WeltecCommonsForm
{
    internal class Staff : Person
    {
        string title;

        public Staff()
        {
        }

        public override int GetBorrowLimit()
        {
            throw new NotImplementedException();
        }

    }
}
