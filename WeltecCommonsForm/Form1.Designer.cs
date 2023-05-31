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
            CurrentBorrowed = new ListBox();
            ViewUserDetails = new Button();
            PersonFNameLabel = new Label();
            PersonLNameLabel = new Label();
            PersonIdLabel = new Label();
            BorrowersInfoGroup = new GroupBox();
            PersonFName = new Label();
            PersonId = new Label();
            PersonLName = new Label();
            Search = new TextBox();
            SearchResults = new Label();
            IssueItem = new Button();
            ViewCatalogue = new Button();
            ItemInfoGroup = new GroupBox();
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
            pictureBox1 = new PictureBox();
            BorrowersInfoGroup.SuspendLayout();
            ItemInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CurrentBorrowed
            // 
            CurrentBorrowed.FormattingEnabled = true;
            CurrentBorrowed.ItemHeight = 15;
            CurrentBorrowed.Location = new Point(12, 41);
            CurrentBorrowed.Name = "CurrentBorrowed";
            CurrentBorrowed.Size = new Size(437, 454);
            CurrentBorrowed.TabIndex = 0;
            CurrentBorrowed.SelectedIndexChanged += CurrentBorrowed_SelectedIndexChanged;
            // 
            // ViewUserDetails
            // 
            ViewUserDetails.Location = new Point(456, 103);
            ViewUserDetails.Name = "ViewUserDetails";
            ViewUserDetails.Size = new Size(161, 37);
            ViewUserDetails.TabIndex = 1;
            ViewUserDetails.Text = "View User";
            ViewUserDetails.UseVisualStyleBackColor = true;
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
            BorrowersInfoGroup.Controls.Add(PersonFName);
            BorrowersInfoGroup.Controls.Add(PersonId);
            BorrowersInfoGroup.Controls.Add(PersonLName);
            BorrowersInfoGroup.Controls.Add(PersonFNameLabel);
            BorrowersInfoGroup.Controls.Add(PersonIdLabel);
            BorrowersInfoGroup.Controls.Add(PersonLNameLabel);
            BorrowersInfoGroup.Location = new Point(455, 12);
            BorrowersInfoGroup.Name = "BorrowersInfoGroup";
            BorrowersInfoGroup.Size = new Size(162, 85);
            BorrowersInfoGroup.TabIndex = 7;
            BorrowersInfoGroup.TabStop = false;
            BorrowersInfoGroup.Text = "Borrows Info";
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
            IssueItem.Location = new Point(12, 501);
            IssueItem.Name = "IssueItem";
            IssueItem.Size = new Size(75, 35);
            IssueItem.TabIndex = 10;
            IssueItem.Text = "Issue Item";
            IssueItem.UseVisualStyleBackColor = true;
            // 
            // ViewCatalogue
            // 
            ViewCatalogue.Location = new Point(93, 501);
            ViewCatalogue.Name = "ViewCatalogue";
            ViewCatalogue.Size = new Size(114, 35);
            ViewCatalogue.TabIndex = 11;
            ViewCatalogue.Text = "View Catalogue";
            ViewCatalogue.UseVisualStyleBackColor = true;
            ViewCatalogue.Click += ViewCatalogue_Click;
            // 
            // ItemInfoGroup
            // 
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
            ItemInfoGroup.Location = new Point(456, 146);
            ItemInfoGroup.Name = "ItemInfoGroup";
            ItemInfoGroup.Size = new Size(297, 146);
            ItemInfoGroup.TabIndex = 12;
            ItemInfoGroup.TabStop = false;
            ItemInfoGroup.Text = "Item Info";
            // 
            // ItemType
            // 
            ItemType.AutoSize = true;
            ItemType.Location = new Point(81, 114);
            ItemType.Name = "ItemType";
            ItemType.Size = new Size(34, 15);
            ItemType.TabIndex = 9;
            ItemType.Text = "Book";
            // 
            // ItemDesc
            // 
            ItemDesc.AutoSize = true;
            ItemDesc.Location = new Point(81, 90);
            ItemDesc.Name = "ItemDesc";
            ItemDesc.Size = new Size(30, 15);
            ItemDesc.TabIndex = 8;
            ItemDesc.Text = "Blah";
            // 
            // ItemIsbn
            // 
            ItemIsbn.AutoSize = true;
            ItemIsbn.Location = new Point(81, 66);
            ItemIsbn.Name = "ItemIsbn";
            ItemIsbn.Size = new Size(71, 15);
            ItemIsbn.TabIndex = 7;
            ItemIsbn.Text = "AHDH46546";
            // 
            // ItemAuthor
            // 
            ItemAuthor.AutoSize = true;
            ItemAuthor.Location = new Point(81, 42);
            ItemAuthor.Name = "ItemAuthor";
            ItemAuthor.Size = new Size(65, 15);
            ItemAuthor.TabIndex = 6;
            ItemAuthor.Text = "Bob Bobby";
            // 
            // ItemTitle
            // 
            ItemTitle.AutoSize = true;
            ItemTitle.Location = new Point(81, 18);
            ItemTitle.Name = "ItemTitle";
            ItemTitle.Size = new Size(38, 15);
            ItemTitle.TabIndex = 5;
            ItemTitle.Text = "Green";
            // 
            // ItemTypeLabel
            // 
            ItemTypeLabel.AutoSize = true;
            ItemTypeLabel.Location = new Point(41, 114);
            ItemTypeLabel.Name = "ItemTypeLabel";
            ItemTypeLabel.Size = new Size(34, 15);
            ItemTypeLabel.TabIndex = 4;
            ItemTypeLabel.Text = "Type:";
            // 
            // ItemDescLabel
            // 
            ItemDescLabel.AutoSize = true;
            ItemDescLabel.Location = new Point(5, 90);
            ItemDescLabel.Name = "ItemDescLabel";
            ItemDescLabel.Size = new Size(70, 15);
            ItemDescLabel.TabIndex = 3;
            ItemDescLabel.Text = "Description:";
            // 
            // ItemISBNLabel
            // 
            ItemISBNLabel.AutoSize = true;
            ItemISBNLabel.Location = new Point(40, 66);
            ItemISBNLabel.Name = "ItemISBNLabel";
            ItemISBNLabel.Size = new Size(35, 15);
            ItemISBNLabel.TabIndex = 2;
            ItemISBNLabel.Text = "ISBN:";
            // 
            // ItemAuthorLabel
            // 
            ItemAuthorLabel.AutoSize = true;
            ItemAuthorLabel.Location = new Point(28, 42);
            ItemAuthorLabel.Name = "ItemAuthorLabel";
            ItemAuthorLabel.Size = new Size(47, 15);
            ItemAuthorLabel.TabIndex = 1;
            ItemAuthorLabel.Text = "Author:";
            // 
            // ItemTitleLabel
            // 
            ItemTitleLabel.AutoSize = true;
            ItemTitleLabel.Location = new Point(43, 18);
            ItemTitleLabel.Name = "ItemTitleLabel";
            ItemTitleLabel.Size = new Size(32, 15);
            ItemTitleLabel.TabIndex = 0;
            ItemTitleLabel.Text = "Title:";
            // 
            // ViewDetails
            // 
            ViewDetails.Location = new Point(455, 298);
            ViewDetails.Name = "ViewDetails";
            ViewDetails.Size = new Size(161, 37);
            ViewDetails.TabIndex = 13;
            ViewDetails.Text = "View Details";
            ViewDetails.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(623, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 120);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 546);
            Controls.Add(pictureBox1);
            Controls.Add(ViewDetails);
            Controls.Add(ItemInfoGroup);
            Controls.Add(ViewCatalogue);
            Controls.Add(IssueItem);
            Controls.Add(SearchResults);
            Controls.Add(Search);
            Controls.Add(BorrowersInfoGroup);
            Controls.Add(ViewUserDetails);
            Controls.Add(CurrentBorrowed);
            Name = "FormMain";
            Text = "Library Catalogue";
            BorrowersInfoGroup.ResumeLayout(false);
            BorrowersInfoGroup.PerformLayout();
            ItemInfoGroup.ResumeLayout(false);
            ItemInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CurrentBorrowed;
        private Button ViewUserDetails;
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
        private PictureBox pictureBox1;
        private Label ItemType;
        private Label ItemDesc;
        private Label ItemIsbn;
        private Label ItemAuthor;
        private Label ItemTitle;
        private Label ItemTypeLabel;
    }
}