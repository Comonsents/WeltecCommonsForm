namespace WeltecCommonsForm
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsersListBox = new ListBox();
            UserListSearch = new TextBox();
            SuspendLayout();
            // 
            // UsersListBox
            // 
            UsersListBox.FormattingEnabled = true;
            UsersListBox.ItemHeight = 15;
            UsersListBox.Location = new Point(12, 41);
            UsersListBox.Name = "UsersListBox";
            UsersListBox.Size = new Size(239, 259);
            UsersListBox.TabIndex = 0;
            UsersListBox.SelectedIndexChanged += UsersListBox_SelectedIndexChanged;
            // 
            // UserListSearch
            // 
            UserListSearch.Location = new Point(12, 12);
            UserListSearch.Name = "UserListSearch";
            UserListSearch.Size = new Size(240, 23);
            UserListSearch.TabIndex = 1;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 314);
            Controls.Add(UserListSearch);
            Controls.Add(UsersListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UsersForm";
            Text = "UsersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersListBox;
        private TextBox UserListSearch;
    }
}