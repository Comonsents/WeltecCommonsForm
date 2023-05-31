namespace WeltecCommonsForm
{
    public partial class FormMain : Form
    {
        
        SortedDictionary<string, Catalogue> itemInfo = new SortedDictionary<string, Catalogue>();
        static string[] headers = new string[6];
        Catalogue catalogue = new Catalogue();
        public FormMain()
        {

            
            InitializeComponent();
            var path = @"../../../datafiles/records.csv";
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines) 
            {
                if (line.StartsWith("Type"))
                {
                    headers = line.Split(' ');
                }
                else
                {
                    string[] info = line.Split(',');
                    itemInfo.Add(info[3], new Catalogue //Title, Author, Description, ISBN, Type, Year
                    {
                        Author = info[2],
                        Description = info[5],
                        Isbn = info[1],
                        Type = info[0],
                        Year = int.Parse(info[4])
                        
                    });
                }
            }

            RefreshForm();

        }

        private void RefreshForm()
        {
            CurrentBorrowed.Sorted = true;
            CurrentBorrowed.DataSource = new BindingSource(itemInfo, null);
            CurrentBorrowed.ValueMember = "Key";
        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCatalogue_Click(object sender, EventArgs e)
        {
            CatalogueView view = new CatalogueView();
            view.Show();
        }
    }
}