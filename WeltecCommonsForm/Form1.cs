namespace WeltecCommonsForm
{
    public partial class FormMain : Form
    {

        SortedDictionary<string, Catalogue> currrentUsersBorrowedItems = new SortedDictionary<string, Catalogue>();
        static string[] headers = new string[6];
        Catalogue selectedItemInCatalogue = new Catalogue();


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
                        Title = info[3],
                        Author = info[2],
                        Description = info[5],
                        Isbn = info[1],
                        Type = info[0],
                        Year = int.Parse(info[4])

                    });
                }
            }
            Person foundUser = GlobalData.users[0];
            Program.selectedUser = GlobalData.users[0].FName;
            if (foundUser != null)
            {
                PersonFName.Text = foundUser.FName;
                PersonLName.Text = foundUser.LName;
                PersonId.Text = foundUser.ID.ToString();

            }
            RefreshForm();

        }

        private void RefreshForm()
        {
            if (currrentUsersBorrowedItems.Count > 0)
            {
                CurrentBorrowed.Sorted = true;
                CurrentBorrowed.DataSource = new BindingSource(currrentUsersBorrowedItems, null);
                CurrentBorrowed.ValueMember = "Key";
            }
            else
            {
                ItemTitle.Text = "";
                ItemAuthor.Text = "";
                ItemDesc.Text = "";
                ItemIsbn.Text = "";
                ItemType.Text = "";
            }

        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentBorrowed.SelectedIndex >= 0)
            {
                string selectedItem = CurrentBorrowed.SelectedValue.ToString();
                if (currrentUsersBorrowedItems.ContainsKey(selectedItem))
                {
                    Catalogue selectedItemInCatalogue = currrentUsersBorrowedItems[selectedItem];
                    ItemTitle.Text = selectedItemInCatalogue.Title;
                    ItemAuthor.Text = selectedItemInCatalogue.Author;
                    ItemDesc.Text = selectedItemInCatalogue.Description;
                    ItemIsbn.Text = selectedItemInCatalogue.Isbn;
                    ItemType.Text = selectedItemInCatalogue.Type;

                }


            }
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
                int foundUser = GlobalData.users.FindIndex(users => users.FName == Program.selectedUser);
                Person selectedUser = GlobalData.users[foundUser];
                if (!selectedUser.BorrowedItems.ContainsKey(GlobalData.itemCatalogue[Program.selectedItem]))
                {
                    currrentUsersBorrowedItems.Add(Program.selectedItem, GlobalData.itemCatalogue[Program.selectedItem]);

                    if (foundUser >= 0)
                    {
                        ;
                        if (GlobalData.itemCatalogue.ContainsKey(Program.selectedItem))
                        {

                            DateTime dueDate = DateTime.Now.AddDays(28);
                            selectedUser.BorrowedItems.Add(GlobalData.itemCatalogue[Program.selectedItem], dueDate);
                            //PrintUserItems(selectedUser);
                        }
                        else
                        {
                            MessageBox.Show("Error finding: " + Program.selectedItem, "Search Error"); ;
                        }


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

        /* TESTING CODE BEACUSE IT WASNT WORKING LOL
        private void PrintUserItems(Person selectedPerson)
        {
            foreach (KeyValuePair<Catalogue, DateTime> item in selectedPerson.BorrowedItems)
            {
                Catalogue borrowedItem = item.Key;
                DateTime dueDate = item.Value;
                string logEntry = $"User: {selectedPerson.FName} {selectedPerson.LName}, Borrowed Item: {borrowedItem.Title}, Due Date: {dueDate}";
                MessageBox.Show(logEntry);
            }
        }
        */
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
                CurrentBorrowed.DataSource = null; 
                CurrentBorrowed.Items.Clear();
                currrentUsersBorrowedItems.Clear();

                foreach (KeyValuePair<Catalogue, DateTime> item in foundUser.BorrowedItems)
                {
                    Catalogue borrowedItem = item.Key;
                    //DateTime dueDate = item.Value;
                    currrentUsersBorrowedItems.Add(borrowedItem.Title, borrowedItem);
                }
                //currrentUsersBorrowedItems.Clear();
                if (foundUser != null)
                {
                    PersonFName.Text = foundUser.FName;
                    PersonLName.Text = foundUser.LName;
                    PersonId.Text = foundUser.ID.ToString();
                    RefreshForm();

                }
                else
                {
                    MessageBox.Show("Error finding: " + Program.selectedUser, "Search Error");
                }
            }
        }
    }
}