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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            UsersListBox.DataSource = new BindingSource(GlobalData.users, null);
            UsersListBox.ValueMember = "fName";
            UsersListBox.DisplayMember = "FullName";
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectUserFromList_Click(object sender, EventArgs e)
        {
            Program.selectedUser = UsersListBox.SelectedValue.ToString();
            this.Close();
        }
    }
}
