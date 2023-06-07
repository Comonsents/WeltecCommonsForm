namespace WeltecCommonsForm
{
    public partial class FormMain : Form
    {

        SortedDictionary<string, Catalogue> currrentUsersBorrowedItems = new SortedDictionary<string, Catalogue>();
        static string[] headers = new string[6];
        int? currentUsersBorrowLimit;


        public FormMain()
        {


            InitializeComponent();
            //testUsers
            GlobalData.users.Add(new Student("Ben", "Hodgson", 123456, DateTime.Now, 0, Image.FromFile(@"../../../datafiles/profile_1.png")));
            GlobalData.users.Add(new Student("Lea", "Hung", 987654, DateTime.Now, 0, Image.FromFile(@"../../../datafiles/profile_2.png")));
            GlobalData.users.Add(new Student("Bob", "Bobby", 112233, DateTime.Now, 0, Image.FromFile(@"../../../datafiles/profile_3.png")));
            GlobalData.users.Add(new Staff("Lecturer", "Person", 999999, DateTime.Now, 0, Image.FromFile(@"../../../datafiles/profile_4.png"), "Mr"));

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
            UsersForm view = new UsersForm();
            view.FormClosed += new FormClosedEventHandler(UpdateSelectedUser);
            view.ShowDialog();
            RefreshForm(currrentUsersBorrowedItems);

        }

        private void RefreshForm(SortedDictionary<string, Catalogue> dict)
        {
            if (dict.Count > 0)
            {
                CurrentBorrowed.Sorted = true;
                CurrentBorrowed.DataSource = new BindingSource(dict, null);
                CurrentBorrowed.ValueMember = "Key";
                CurrentBorrowed.DisplayMember = "Key";
            }
            else
            {
                CurrentBorrowed.DataSource = null;
                CurrentBorrowed.Items.Clear();
                ItemTitle.Text = "";
                ItemAuthor.Text = "";
                ItemDesc.Text = "";
                ItemIsbn.Text = "";
                ItemType.Text = "";
                ItemDueDate.Text = "";
            }

        }

        private static Person GetSelectedUser()
        {
            int foundUser = GlobalData.users.FindIndex(users => users.FName == Program.selectedUser);
            if (foundUser >= 0)
            {
                Person selectedUser = GlobalData.users[foundUser];
                return selectedUser;
            }
            else
            {
                return null;
            }
        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentBorrowed.SelectedIndex >= 0)
            {
                string selectedItem = CurrentBorrowed.SelectedValue.ToString();
                Person selectedUser = GetSelectedUser();
                if (currrentUsersBorrowedItems.ContainsKey(selectedItem))
                {
                    Catalogue selectedItemInCatalogue = currrentUsersBorrowedItems[selectedItem];
                    ItemTitle.Text = selectedItemInCatalogue.Title;
                    ItemAuthor.Text = selectedItemInCatalogue.Author;
                    ItemDesc.Text = selectedItemInCatalogue.Description;
                    ItemIsbn.Text = selectedItemInCatalogue.Isbn;
                    ItemType.Text = selectedItemInCatalogue.Type;
                    DateTime dueDate = selectedUser.BorrowedItems[selectedItemInCatalogue];
                    ItemDueDate.Text = dueDate.ToString("d");
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
                Person selectedUser = GetSelectedUser();
                if (!selectedUser.BorrowedItems.ContainsKey(GlobalData.itemCatalogue[Program.selectedItem]))
                {
                    currrentUsersBorrowedItems.Add(Program.selectedItem, GlobalData.itemCatalogue[Program.selectedItem]);
                    ;
                    if (GlobalData.itemCatalogue.ContainsKey(Program.selectedItem))
                    {
                        //4 weeks from issue is the due date
                        DateTime dueDate = DateTime.Now.AddDays(28);
                        selectedUser.BorrowedItems.Add(GlobalData.itemCatalogue[Program.selectedItem], dueDate);
                    }
                    else
                    {
                        MessageBox.Show("Error finding: " + Program.selectedItem, "Search Error"); ;
                    }


                }
                Program.selectedItem = null;
                RefreshForm(currrentUsersBorrowedItems);
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


                Person foundUser = GetSelectedUser();
                currrentUsersBorrowedItems.Clear();

                foreach (KeyValuePair<Catalogue, DateTime> item in foundUser.BorrowedItems)
                {
                    Catalogue borrowedItem = item.Key;
                    string displayMember = item.Key.Title.ToString();

                    //DateTime dueDate = item.Value;
                    currrentUsersBorrowedItems.Add(displayMember, borrowedItem);
                }
                if (foundUser != null)
                {
                    PersonFName.Text = foundUser.FName;
                    PersonLName.Text = foundUser.LName;
                    PersonId.Text = foundUser.ID.ToString();
                    PersonFines.Text = foundUser.GetFine().ToString();
                    PersonPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    PersonPicture.Image = foundUser.ProfilePicture;
                    RefreshForm(currrentUsersBorrowedItems);

                }
                else
                {
                    MessageBox.Show("Error finding: " + Program.selectedUser, "Search Error");
                }
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text != "")
            {
                if (Search.Text.Length == 1)
                {
                    Search.Text = Search.Text.ToString().ToUpper();
                    Search.Select(Search.Text.Length, 0);
                }

                Dictionary<string, Catalogue> query = currrentUsersBorrowedItems.Where(result => result.Key.Contains(Search.Text))
                    .ToDictionary(result => result.Key, result => result.Value);
                if (query.Count > 0)
                {
                    SortedDictionary<string, Catalogue> filtered = new SortedDictionary<string, Catalogue>(query);
                    RefreshForm(filtered);
                    if (filtered.Count == 1)
                    {
                        SearchResults.Text = $"{filtered.Count} match";
                    }
                    else
                    {
                        SearchResults.Text = $"{filtered.Count} matches";
                    }
                }
                else
                {
                    SearchResults.Text = "No Results";
                }
            }
            else
            {
                RefreshForm(currrentUsersBorrowedItems);
            }
        }
    }
}