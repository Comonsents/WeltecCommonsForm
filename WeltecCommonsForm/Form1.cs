using Microsoft.VisualBasic.ApplicationServices;

namespace WeltecCommonsForm
{
    public partial class FormMain : Form
    {

        SortedDictionary<string, Catalogue> currrentUsersBorrowedItems = new SortedDictionary<string, Catalogue>();
        static string[] headers = new string[6];
        Dictionary<Person, Borrowed> currentUsers = new Dictionary<Person, Borrowed>();


        public FormMain()
        {


            InitializeComponent();
            //testUsers
            GlobalData.users.Add(new Student("Ben", "Hodgson", 123456, DateTime.Now, 0));
            GlobalData.users.Add(new Student("Lea", "Hung", 987654, DateTime.Now, 0));
            GlobalData.users.Add(new Student("Bob", "Bobby", 112233, DateTime.Now, 0));
            GlobalData.users.Add(new Staff("Lecturer", "Person", 999999, DateTime.Now, 0, "Mr"));

            //creating borrowed list for each user
            //uses dictionary to with the key value pair being Person class => Borrowed class
            foreach (Person person in GlobalData.users)
            {
                Borrowed borrowed = new Borrowed();
                borrowed.Borrower = person;
                borrowed.BorrowedItems = new SortedDictionary<Catalogue, DateTime>();
                currentUsers.Add(person, borrowed);
            }

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
            if (currrentUsersBorrowedItems.Count > 0)
            {
                CurrentBorrowed.Sorted = true;
                CurrentBorrowed.DataSource = new BindingSource(currrentUsersBorrowedItems, null);
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
                if (!currrentUsersBorrowedItems.ContainsKey(Program.selectedItem))
                {
                    currrentUsersBorrowedItems.Add(Program.selectedItem, GlobalData.itemCatalogue[Program.selectedItem]);

                    int foundUser = GlobalData.users.FindIndex(users => users.FName == Program.selectedUser);
                    if (foundUser >= 0)
                    {
                        Person selectedUser = GlobalData.users[foundUser];
                        DateTime dueDate = DateTime.Now.AddDays(28);
                        currentUsers[selectedUser].BorrowedItems.Add(GlobalData.itemCatalogue[Program.selectedItem], dueDate);
                        PrintUserItems(selectedUser);
                    }
                    else
                    {
                        MessageBox.Show("Error finding: " + Program.selectedUser, "Search Error");
                    }
                }
                Program.selectedItem = null;
                RefreshForm();
            }
        }

        private void PrintUserItems(Person selectedPerson)
        {
            Borrowed borrowed = currentUsers[selectedPerson];
            foreach (KeyValuePair<Catalogue, DateTime> item in borrowed.BorrowedItems)
            {
                Catalogue borrowedItem = item.Key;
                DateTime dueDate = item.Value;
                string logEntry = $"User: {selectedPerson.FName} {selectedPerson.LName}, Borrowed Item: {borrowedItem.Title}, Due Date: {dueDate}";
                MessageBox.Show(logEntry);
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
            }
        }
    }
}