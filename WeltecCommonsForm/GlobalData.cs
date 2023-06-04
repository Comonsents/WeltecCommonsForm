namespace WeltecCommonsForm
{
    internal static class GlobalData
    {
        public static SortedDictionary<string, Catalogue> itemCatalogue { get; } = new SortedDictionary<string, Catalogue>();
        public static List<Person> users { get; } = new List<Person>();
    }
}
