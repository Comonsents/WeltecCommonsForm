namespace WeltecCommonsForm
{
    internal class Catalogue
    {
        string title;
        string author;
        string description;
        string isbn;
        string type;
        int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Description { get => description; set => description = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }

    }
}
