namespace WeltecCommonsForm
{
    partial class CatalogueView
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
            RemoveItem = new Button();
            AddItem = new Button();
            SearchResults = new Label();
            Search = new TextBox();
            itemCatalogue = new ListBox();
            UpdateItem = new Button();
            SuspendLayout();
            // 
            // RemoveItem
            // 
            RemoveItem.Location = new Point(93, 499);
            RemoveItem.Name = "RemoveItem";
            RemoveItem.Size = new Size(114, 35);
            RemoveItem.TabIndex = 16;
            RemoveItem.Text = "Remove";
            RemoveItem.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            AddItem.Location = new Point(12, 499);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(75, 35);
            AddItem.TabIndex = 15;
            AddItem.Text = "Add";
            AddItem.UseVisualStyleBackColor = true;
            // 
            // SearchResults
            // 
            SearchResults.AutoSize = true;
            SearchResults.Location = new Point(118, 18);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(89, 15);
            SearchResults.TabIndex = 14;
            SearchResults.Text = "Result(s) Found";
            // 
            // Search
            // 
            Search.Location = new Point(12, 10);
            Search.Name = "Search";
            Search.Size = new Size(100, 23);
            Search.TabIndex = 13;
            // 
            // itemCatalogue
            // 
            itemCatalogue.FormattingEnabled = true;
            itemCatalogue.ItemHeight = 15;
            itemCatalogue.Location = new Point(12, 39);
            itemCatalogue.Name = "itemCatalogue";
            itemCatalogue.Size = new Size(589, 454);
            itemCatalogue.TabIndex = 12;
            itemCatalogue.SelectedIndexChanged += CurrentBorrowed_SelectedIndexChanged;
            // 
            // UpdateItem
            // 
            UpdateItem.Location = new Point(213, 499);
            UpdateItem.Name = "UpdateItem";
            UpdateItem.Size = new Size(114, 35);
            UpdateItem.TabIndex = 17;
            UpdateItem.Text = "Update";
            UpdateItem.UseVisualStyleBackColor = true;
            // 
            // CatalogueView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 543);
            Controls.Add(UpdateItem);
            Controls.Add(RemoveItem);
            Controls.Add(AddItem);
            Controls.Add(SearchResults);
            Controls.Add(Search);
            Controls.Add(itemCatalogue);
            Name = "CatalogueView";
            Text = "CatalogueView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveItem;
        private Button AddItem;
        private Label SearchResults;
        private TextBox Search;
        private ListBox itemCatalogue;
        private Button UpdateItem;
    }
}