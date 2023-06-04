namespace WeltecCommonsForm
{
    public partial class FormMain : Form
    {

        SortedDictionary<string, Catalogue> borrowedItems = new SortedDictionary<string, Catalogue>();
        static string[] headers = new string[6];
        Borrowed Borrowed = new Borrowed();
        //List<Person> users = new();


        public FormMain()
        {


            InitializeComponent();
            //testUsers
            GlobalData.users.Add(new Student("Ben", "Hodgson", 123456, DateTime.Now, 0));
            GlobalData.users.Add(new Student("Lea", "Hung", 987654, DateTime.Now, 0));
            GlobalData.users.Add(new Student("Bob", "Bobby", 112233, DateTime.Now, 0));
            GlobalData.users.Add(new Staff("Lecturer", "Person", 999999, DateTime.Now, 0, "Mr"));

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
                    GlobalData.itemCatalogue.Add(info[3], new Catalogue //Title, Author, Description, ISBN, Type, Year
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
            if (borrowedItems.Count > 0)
            {
                CurrentBorrowed.Sorted = true;
                CurrentBorrowed.DataSource = new BindingSource(borrowedItems, null);
                CurrentBorrowed.ValueMember = "key";
            }

        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCatalogue_Click(object sender, EventArgs e)
        {
            if (GlobalData.itemCatalogue != null)
            {
                CatalogueView view = new CatalogueView();

                view.Show();

            }

        }
        private void IssueItem_Click(object sender, EventArgs e)
        {
            ItemForm view = new();
            view.FormClosed += new FormClosedEventHandler(IssueSelectedItem);
            view.ShowDialog();
        }

        private void IssueSelectedItem(object? sender, FormClosedEventArgs e)
        {
            if (Program.selectedItem != null)
            {
                if (!borrowedItems.ContainsKey(Program.selectedItem))
                {
                    borrowedItems.Add(Program.selectedItem, GlobalData.itemCatalogue[Program.selectedItem]);
                    Borrowed

                }
                Program.selectedItem = null;
                RefreshForm();
            }
        }

        private void ViewUsersList_Click(object sender, EventArgs e)
        {
            UsersForm view = new UsersForm();
            view.FormClosed += new FormClosedEventHandler(UpdateSelectedUser);
            view.ShowDialog();
        }

        private void UpdateSelectedUser(object? sender, FormClosedEventArgs e)
        {
            if (Program.selectedUser != null)
            {
                Person foundUser = GlobalData.users.FirstOrDefault(users => users.FName == Program.selectedUser);
                if (foundUser != null)
                {
                    PersonFName.Text = foundUser.FName;
                    PersonLName.Text = foundUser.LName;
                    PersonId.Text = foundUser.ID.ToString();

                }
                else
                {
                    MessageBox.Show("Error finding: " + Program.selectedUser, "Search Error");
                }
                Program.selectedUser = null;
            }
        }
    }
}