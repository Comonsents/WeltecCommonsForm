using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeltecCommonsForm
{
    public partial class ItemForm : Form
    {
        SortedDictionary<string, Catalogue> catalogue = new SortedDictionary<string, Catalogue>();
        public ItemForm()
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
            itemCatalogueIssue.Sorted = true;
            itemCatalogueIssue.DataSource = new BindingSource(catalogue, null);
            itemCatalogueIssue.ValueMember = "Key";
        }

        private void itemCatalogueIssue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Program.selectedItem = itemCatalogueIssue.SelectedValue.ToString();
            this.Close();
        }
    }
}
