namespace WeltecCommonsForm
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            CurrentBorrowed = new ListBox();
            PersonFNameLabel = new Label();
            PersonLNameLabel = new Label();
            PersonIdLabel = new Label();
            BorrowersInfoGroup = new GroupBox();
            PersonFines = new Label();
            PersonFinesLabel = new Label();
            PersonFName = new Label();
            PersonId = new Label();
            PersonLName = new Label();
            Search = new TextBox();
            SearchResults = new Label();
            IssueItem = new Button();
            ViewCatalogue = new Button();
            ItemInfoGroup = new GroupBox();
            ItemDueDate = new Label();
            ItemDueDateLabel = new Label();
            ItemType = new Label();
            ItemDesc = new Label();
            ItemIsbn = new Label();
            ItemAuthor = new Label();
            ItemTitle = new Label();
            ItemTypeLabel = new Label();
            ItemDescLabel = new Label();
            ItemISBNLabel = new Label();
            ItemAuthorLabel = new Label();
            ItemTitleLabel = new Label();
            ViewDetails = new Button();
            PersonPicture = new PictureBox();
            ViewUsersList = new Button();
            BorrowersInfoGroup.SuspendLayout();
            ItemInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonPicture).BeginInit();
            SuspendLayout();
            // 
            // CurrentBorrowed
            // 
            CurrentBorrowed.FormattingEnabled = true;
            CurrentBorrowed.ItemHeight = 15;
            CurrentBorrowed.Location = new Point(12, 41);
            CurrentBorrowed.Name = "CurrentBorrowed";
            CurrentBorrowed.Size = new Size(195, 349);
            CurrentBorrowed.TabIndex = 0;
            CurrentBorrowed.SelectedIndexChanged += CurrentBorrowed_SelectedIndexChanged;
            // 
            // PersonFNameLabel
            // 
            PersonFNameLabel.AutoSize = true;
            PersonFNameLabel.Location = new Point(6, 23);
            PersonFNameLabel.Name = "PersonFNameLabel";
            PersonFNameLabel.Size = new Size(67, 15);
            PersonFNameLabel.TabIndex = 4;
            PersonFNameLabel.Text = "First Name:";
            // 
            // PersonLNameLabel
            // 
            PersonLNameLabel.AutoSize = true;
            PersonLNameLabel.Location = new Point(6, 38);
            PersonLNameLabel.Name = "PersonLNameLabel";
            PersonLNameLabel.Size = new Size(66, 15);
            PersonLNameLabel.TabIndex = 5;
            PersonLNameLabel.Text = "Last Name:";
            // 
            // PersonIdLabel
            // 
            PersonIdLabel.AutoSize = true;
            PersonIdLabel.Location = new Point(51, 53);
            PersonIdLabel.Name = "PersonIdLabel";
            PersonIdLabel.Size = new Size(21, 15);
            PersonIdLabel.TabIndex = 6;
            PersonIdLabel.Text = "ID:";
            // 
            // BorrowersInfoGroup
            // 
            BorrowersInfoGroup.Controls.Add(PersonFines);
            BorrowersInfoGroup.Controls.Add(PersonFinesLabel);
            BorrowersInfoGroup.Controls.Add(PersonFName);
            BorrowersInfoGroup.Controls.Add(PersonId);
            BorrowersInfoGroup.Controls.Add(PersonLName);
            BorrowersInfoGroup.Controls.Add(PersonFNameLabel);
            BorrowersInfoGroup.Controls.Add(PersonIdLabel);
            BorrowersInfoGroup.Controls.Add(PersonLNameLabel);
            BorrowersInfoGroup.Location = new Point(212, 16);
            BorrowersInfoGroup.Name = "BorrowersInfoGroup";
            BorrowersInfoGroup.Size = new Size(162, 96);
            BorrowersInfoGroup.TabIndex = 7;
            BorrowersInfoGroup.TabStop = false;
            BorrowersInfoGroup.Text = "Borrows Info";
            // 
            // PersonFines
            // 
            PersonFines.AutoSize = true;
            PersonFines.Location = new Point(78, 68);
            PersonFines.Name = "PersonFines";
            PersonFines.Size = new Size(19, 15);
            PersonFines.TabIndex = 11;
            PersonFines.Text = "$0";
            // 
            // PersonFinesLabel
            // 
            PersonFinesLabel.AutoSize = true;
            PersonFinesLabel.Location = new Point(35, 68);
            PersonFinesLabel.Name = "PersonFinesLabel";
            PersonFinesLabel.Size = new Size(37, 15);
            PersonFinesLabel.TabIndex = 10;
            PersonFinesLabel.Text = "Fines:";
            // 
            // PersonFName
            // 
            PersonFName.AutoSize = true;
            PersonFName.Location = new Point(78, 23);
            PersonFName.Name = "PersonFName";
            PersonFName.Size = new Size(28, 15);
            PersonFName.TabIndex = 7;
            PersonFName.Text = "Bob";
            // 
            // PersonId
            // 
            PersonId.AutoSize = true;
            PersonId.Location = new Point(78, 53);
            PersonId.Name = "PersonId";
            PersonId.Size = new Size(43, 15);
            PersonId.TabIndex = 9;
            PersonId.Text = "123456";
            // 
            // PersonLName
            // 
            PersonLName.AutoSize = true;
            PersonLName.Location = new Point(78, 38);
            PersonLName.Name = "PersonLName";
            PersonLName.Size = new Size(41, 15);
            PersonLName.TabIndex = 8;
            PersonLName.Text = "Bobby";
            // 
            // Search
            // 
            Search.Location = new Point(12, 12);
            Search.Name = "Search";
            Search.Size = new Size(100, 23);
            Search.TabIndex = 8;
            Search.TextChanged += Search_TextChanged;
            // 
            // SearchResults
            // 
            SearchResults.AutoSize = true;
            SearchResults.Location = new Point(118, 20);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(89, 15);
            SearchResults.TabIndex = 9;
            SearchResults.Text = "Result(s) Found";
            // 
            // IssueItem
            // 
            IssueItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IssueItem.Location = new Point(12, 396);
            IssueItem.Name = "IssueItem";
            IssueItem.Size = new Size(75, 35);
            IssueItem.TabIndex = 10;
            IssueItem.Text = "Issue Item";
            IssueItem.UseVisualStyleBackColor = true;
            IssueItem.Click += IssueItem_Click;
            // 
            // ViewCatalogue
            // 
            ViewCatalogue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCatalogue.Location = new Point(93, 396);
            ViewCatalogue.Name = "ViewCatalogue";
            ViewCatalogue.Size = new Size(114, 35);
            ViewCatalogue.TabIndex = 11;
            ViewCatalogue.Text = "View Catalogue";
            ViewCatalogue.UseVisualStyleBackColor = true;
            ViewCatalogue.Click += ViewCatalogue_Click;
            // 
            // ItemInfoGroup
            // 
            ItemInfoGroup.Controls.Add(ItemDueDate);
            ItemInfoGroup.Controls.Add(ItemDueDateLabel);
            ItemInfoGroup.Controls.Add(ItemType);
            ItemInfoGroup.Controls.Add(ItemDesc);
            ItemInfoGroup.Controls.Add(ItemIsbn);
            ItemInfoGroup.Controls.Add(ItemAuthor);
            ItemInfoGroup.Controls.Add(ItemTitle);
            ItemInfoGroup.Controls.Add(ItemTypeLabel);
            ItemInfoGroup.Controls.Add(ItemDescLabel);
            ItemInfoGroup.Controls.Add(ItemISBNLabel);
            ItemInfoGroup.Controls.Add(ItemAuthorLabel);
            ItemInfoGroup.Controls.Add(ItemTitleLabel);
            ItemInfoGroup.Location = new Point(212, 161);
            ItemInfoGroup.Name = "ItemInfoGroup";
            ItemInfoGroup.Size = new Size(297, 180);
            ItemInfoGroup.TabIndex = 12;
            ItemInfoGroup.TabStop = false;
            ItemInfoGroup.Text = "Item Info";
            // 
            // ItemDueDate
            // 
            ItemDueDate.AutoSize = true;
            ItemDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDueDate.Location = new Point(101, 141);
            ItemDueDate.Name = "ItemDueDate";
            ItemDueDate.Size = new Size(47, 15);
            ItemDueDate.TabIndex = 11;
            ItemDueDate.Text = "14/7/22";
            // 
            // ItemDueDateLabel
            // 
            ItemDueDateLabel.AutoSize = true;
            ItemDueDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDueDateLabel.Location = new Point(34, 141);
            ItemDueDateLabel.Name = "ItemDueDateLabel";
            ItemDueDateLabel.Size = new Size(61, 15);
            ItemDueDateLabel.TabIndex = 10;
            ItemDueDateLabel.Text = "Due Date: ";
            // 
            // ItemType
            // 
            ItemType.AutoSize = true;
            ItemType.Location = new Point(101, 120);
            ItemType.Name = "ItemType";
            ItemType.Size = new Size(34, 15);
            ItemType.TabIndex = 9;
            ItemType.Text = "Book";
            // 
            // ItemDesc
            // 
            ItemDesc.AutoSize = true;
            ItemDesc.Location = new Point(101, 96);
            ItemDesc.Name = "ItemDesc";
            ItemDesc.Size = new Size(30, 15);
            ItemDesc.TabIndex = 8;
            ItemDesc.Text = "Blah";
            // 
            // ItemIsbn
            // 
            ItemIsbn.AutoSize = true;
            ItemIsbn.Location = new Point(101, 72);
            ItemIsbn.Name = "ItemIsbn";
            ItemIsbn.Size = new Size(71, 15);
            ItemIsbn.TabIndex = 7;
            ItemIsbn.Text = "AHDH46546";
            // 
            // ItemAuthor
            // 
            ItemAuthor.AutoSize = true;
            ItemAuthor.Location = new Point(101, 48);
            ItemAuthor.Name = "ItemAuthor";
            ItemAuthor.Size = new Size(65, 15);
            ItemAuthor.TabIndex = 6;
            ItemAuthor.Text = "Bob Bobby";
            // 
            // ItemTitle
            // 
            ItemTitle.AutoSize = true;
            ItemTitle.Location = new Point(101, 24);
            ItemTitle.Name = "ItemTitle";
            ItemTitle.Size = new Size(38, 15);
            ItemTitle.TabIndex = 5;
            ItemTitle.Text = "Green";
            // 
            // ItemTypeLabel
            // 
            ItemTypeLabel.AutoSize = true;
            ItemTypeLabel.Location = new Point(61, 120);
            ItemTypeLabel.Name = "ItemTypeLabel";
            ItemTypeLabel.Size = new Size(34, 15);
            ItemTypeLabel.TabIndex = 4;
            ItemTypeLabel.Text = "Type:";
            // 
            // ItemDescLabel
            // 
            ItemDescLabel.AutoSize = true;
            ItemDescLabel.Location = new Point(25, 96);
            ItemDescLabel.Name = "ItemDescLabel";
            ItemDescLabel.Size = new Size(70, 15);
            ItemDescLabel.TabIndex = 3;
            ItemDescLabel.Text = "Description:";
            // 
            // ItemISBNLabel
            // 
            ItemISBNLabel.AutoSize = true;
            ItemISBNLabel.Location = new Point(60, 72);
            ItemISBNLabel.Name = "ItemISBNLabel";
            ItemISBNLabel.Size = new Size(35, 15);
            ItemISBNLabel.TabIndex = 2;
            ItemISBNLabel.Text = "ISBN:";
            // 
            // ItemAuthorLabel
            // 
            ItemAuthorLabel.AutoSize = true;
            ItemAuthorLabel.Location = new Point(48, 48);
            ItemAuthorLabel.Name = "ItemAuthorLabel";
            ItemAuthorLabel.Size = new Size(47, 15);
            ItemAuthorLabel.TabIndex = 1;
            ItemAuthorLabel.Text = "Author:";
            // 
            // ItemTitleLabel
            // 
            ItemTitleLabel.AutoSize = true;
            ItemTitleLabel.Location = new Point(63, 24);
            ItemTitleLabel.Name = "ItemTitleLabel";
            ItemTitleLabel.Size = new Size(32, 15);
            ItemTitleLabel.TabIndex = 0;
            ItemTitleLabel.Text = "Title:";
            // 
            // ViewDetails
            // 
            ViewDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViewDetails.Location = new Point(212, 347);
            ViewDetails.Name = "ViewDetails";
            ViewDetails.Size = new Size(161, 37);
            ViewDetails.TabIndex = 13;
            ViewDetails.Text = "View Details";
            ViewDetails.UseVisualStyleBackColor = true;
            // 
            // PersonPicture
            // 
            PersonPicture.Location = new Point(380, 24);
            PersonPicture.Name = "PersonPicture";
            PersonPicture.Size = new Size(130, 120);
            PersonPicture.TabIndex = 14;
            PersonPicture.TabStop = false;
            // 
            // ViewUsersList
            // 
            ViewUsersList.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViewUsersList.Location = new Point(212, 118);
            ViewUsersList.Name = "ViewUsersList";
            ViewUsersList.Size = new Size(161, 37);
            ViewUsersList.TabIndex = 15;
            ViewUsersList.Text = "User Login";
            ViewUsersList.UseVisualStyleBackColor = true;
            ViewUsersList.Click += ViewUsersList_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(526, 440);
            Controls.Add(ViewUsersList);
            Controls.Add(PersonPicture);
            Controls.Add(ViewDetails);
            Controls.Add(ItemInfoGroup);
            Controls.Add(ViewCatalogue);
            Controls.Add(IssueItem);
            Controls.Add(SearchResults);
            Controls.Add(Search);
            Controls.Add(BorrowersInfoGroup);
            Controls.Add(CurrentBorrowed);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Catalogue";
            BorrowersInfoGroup.ResumeLayout(false);
            BorrowersInfoGroup.PerformLayout();
            ItemInfoGroup.ResumeLayout(false);
            ItemInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PersonPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CurrentBorrowed;
        private Label PersonFNameLabel;
        private Label PersonLNameLabel;
        private Label PersonIdLabel;
        private GroupBox BorrowersInfoGroup;
        private Label PersonFName;
        private Label PersonId;
        private Label PersonLName;
        private TextBox Search;
        private Label SearchResults;
        private Button IssueItem;
        private Button ViewCatalogue;
        private GroupBox ItemInfoGroup;
        private Button ViewDetails;
        private Label ItemDescLabel;
        private Label ItemISBNLabel;
        private Label ItemAuthorLabel;
        private Label ItemTitleLabel;
        private PictureBox PersonPicture;
        private Label ItemType;
        private Label ItemDesc;
        private Label ItemIsbn;
        private Label ItemAuthor;
        private Label ItemTitle;
        private Label ItemTypeLabel;
        private Button ViewUsersList;
        private Label ItemDueDate;
        private Label ItemDueDateLabel;
        private Label PersonFines;
        private Label PersonFinesLabel;
    }
}