namespace WeltecCommonsForm
{
    public partial class CatalogueView : Form
    {
        SortedDictionary<string, Catalogue> catalogue = new SortedDictionary<string, Catalogue>();
        public CatalogueView()
        {
            InitializeComponent();
            if (GlobalData.itemCatalogue != null)
            {
                catalogue = GlobalData.itemCatalogue;
            }

            RefreshForm(catalogue);
        }

        private void RefreshForm(SortedDictionary<string, Catalogue> dict)
        {
            itemCatalogue.Sorted = true;
            itemCatalogue.DataSource = new BindingSource(dict, null);
            itemCatalogue.ValueMember = "Key";
        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                Dictionary<string, Catalogue> query = catalogue.Where(result => result.Key.Contains(Search.Text))
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
                RefreshForm(catalogue);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            CatalogueItemForm form = new CatalogueItemForm(CatalogueItemForm.FormMode.Add, null);
            form.ShowDialog();
            RefreshForm(catalogue);
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            if (itemCatalogue.SelectedIndex >= 0)
            {
                GlobalData.itemCatalogue.Remove(itemCatalogue.SelectedValue.ToString());
                RefreshForm(catalogue);
                
            }

        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            CatalogueItemForm form = new CatalogueItemForm(CatalogueItemForm.FormMode.Edit, itemCatalogue.SelectedValue.ToString());
            form.ShowDialog();
            RefreshForm(catalogue);
        }
    }
}
