namespace WeltecCommonsForm
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            RemoveItem = new Button();
            AddItem = new Button();
            SearchResults = new Label();
            Search = new TextBox();
            itemCatalogueIssue = new ListBox();
            SuspendLayout();
            // 
            // RemoveItem
            // 
            RemoveItem.Location = new Point(93, 500);
            RemoveItem.Name = "RemoveItem";
            RemoveItem.Size = new Size(114, 35);
            RemoveItem.TabIndex = 21;
            RemoveItem.Text = "Cancel";
            RemoveItem.UseVisualStyleBackColor = true;
            RemoveItem.Click += RemoveItem_Click;
            // 
            // AddItem
            // 
            AddItem.Location = new Point(12, 500);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(75, 35);
            AddItem.TabIndex = 20;
            AddItem.Text = "Issue";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // SearchResults
            // 
            SearchResults.AutoSize = true;
            SearchResults.Location = new Point(118, 19);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(89, 15);
            SearchResults.TabIndex = 19;
            SearchResults.Text = "Result(s) Found";
            // 
            // Search
            // 
            Search.Location = new Point(12, 11);
            Search.Name = "Search";
            Search.Size = new Size(100, 23);
            Search.TabIndex = 18;
            // 
            // itemCatalogueIssue
            // 
            itemCatalogueIssue.FormattingEnabled = true;
            itemCatalogueIssue.ItemHeight = 15;
            itemCatalogueIssue.Location = new Point(12, 40);
            itemCatalogueIssue.Name = "itemCatalogueIssue";
            itemCatalogueIssue.Size = new Size(589, 454);
            itemCatalogueIssue.TabIndex = 17;
            itemCatalogueIssue.SelectedIndexChanged += itemCatalogueIssue_SelectedIndexChanged;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 546);
            Controls.Add(RemoveItem);
            Controls.Add(AddItem);
            Controls.Add(SearchResults);
            Controls.Add(Search);
            Controls.Add(itemCatalogueIssue);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemForm";
            Text = "Item Issue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveItem;
        private Button AddItem;
        private Label SearchResults;
        private TextBox Search;
        private ListBox itemCatalogueIssue;
    }
}