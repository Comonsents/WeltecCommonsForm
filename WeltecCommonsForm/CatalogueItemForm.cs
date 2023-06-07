namespace WeltecCommonsForm
{
    public partial class CatalogueItemForm : Form
    {

        public enum FormMode
        {
            Add,
            Edit
        }

        private FormMode currentMode;
        Catalogue selectedItem;
        public CatalogueItemForm(FormMode mode, String? selectedKey)
        {
            InitializeComponent();
            currentMode = mode;

            if (mode == FormMode.Add)
            {
                btnCatalogueAdd.Text = "Add";
            }
            else if (mode == FormMode.Edit)
            {
                btnCatalogueAdd.Text = "Edit";
                selectedItem = GlobalData.itemCatalogue[selectedKey];
                AddTitle.Text = selectedItem.Title;
                AddTitle.Enabled = false;
                AddAuthor.Text = selectedItem.Author;
                AddDescription.Text = selectedItem.Description;
                AddISBN.Text = selectedItem.Isbn;
                AddType.Text = selectedItem.Type;
                AddYear.Text = selectedItem.Year.ToString();
            }
        }

        private void btnCatalogueAdd_Click(object sender, EventArgs e)
        {

            if (currentMode == FormMode.Add)
            {
                string title = AddTitle.Text;
                string author = AddAuthor.Text;
                string description = AddDescription.Text;
                string isbn = AddISBN.Text;
                string type = AddType.Text;
                int year = int.Parse(AddYear.Text);

                Catalogue newItem = new Catalogue
                {
                    Title = title,
                    Author = author,
                    Description = description,
                    Isbn = isbn,
                    Type = type,
                    Year = year,
                };
                GlobalData.itemCatalogue.Add(title, newItem);
                if (GlobalData.itemCatalogue.ContainsKey(title)) { Close(); }

            }
            else if (currentMode == FormMode.Edit)
            {
                string author = AddAuthor.Text;
                string description = AddDescription.Text;
                string isbn = AddISBN.Text;
                string type = AddType.Text;
                int year = int.Parse(AddYear.Text);

                selectedItem.Author = author;
                selectedItem.Description = description;
                selectedItem.Isbn = isbn;
                selectedItem.Type = type;
                selectedItem.Year = year;
                Close();
            }

        }

        private void btnCatalogueCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
