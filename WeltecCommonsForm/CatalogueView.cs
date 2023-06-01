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

            RefreshForm();
        }

        private void RefreshForm()
        {
            itemCatalogue.Sorted = true;
            itemCatalogue.DataSource = new BindingSource(catalogue, null);
            itemCatalogue.ValueMember = "Key";
        }

        private void CurrentBorrowed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
