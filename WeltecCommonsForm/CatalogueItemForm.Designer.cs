namespace WeltecCommonsForm
{
    partial class CatalogueItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueItemForm));
            CatalogueTitle = new Label();
            AddTitle = new TextBox();
            AddAuthor = new TextBox();
            CatalogueAuthor = new Label();
            AddISBN = new TextBox();
            CatalogueIsbn = new Label();
            AddDescription = new TextBox();
            CatalogueDescription = new Label();
            AddYear = new TextBox();
            CatalogueYear = new Label();
            AddType = new TextBox();
            CatalogueType = new Label();
            btnCatalogueAdd = new Button();
            btnCatalogueCancel = new Button();
            SuspendLayout();
            // 
            // CatalogueTitle
            // 
            CatalogueTitle.AutoSize = true;
            CatalogueTitle.Location = new Point(42, 16);
            CatalogueTitle.Name = "CatalogueTitle";
            CatalogueTitle.Size = new Size(29, 15);
            CatalogueTitle.TabIndex = 0;
            CatalogueTitle.Text = "Title";
            // 
            // AddTitle
            // 
            AddTitle.Location = new Point(77, 8);
            AddTitle.Name = "AddTitle";
            AddTitle.Size = new Size(135, 23);
            AddTitle.TabIndex = 1;
            // 
            // AddAuthor
            // 
            AddAuthor.Location = new Point(77, 46);
            AddAuthor.Name = "AddAuthor";
            AddAuthor.Size = new Size(135, 23);
            AddAuthor.TabIndex = 3;
            // 
            // CatalogueAuthor
            // 
            CatalogueAuthor.AutoSize = true;
            CatalogueAuthor.Location = new Point(27, 54);
            CatalogueAuthor.Name = "CatalogueAuthor";
            CatalogueAuthor.Size = new Size(44, 15);
            CatalogueAuthor.TabIndex = 2;
            CatalogueAuthor.Text = "Author";
            // 
            // AddISBN
            // 
            AddISBN.Location = new Point(77, 122);
            AddISBN.Name = "AddISBN";
            AddISBN.Size = new Size(135, 23);
            AddISBN.TabIndex = 7;
            // 
            // CatalogueIsbn
            // 
            CatalogueIsbn.AutoSize = true;
            CatalogueIsbn.Location = new Point(39, 130);
            CatalogueIsbn.Name = "CatalogueIsbn";
            CatalogueIsbn.Size = new Size(32, 15);
            CatalogueIsbn.TabIndex = 6;
            CatalogueIsbn.Text = "ISBN";
            // 
            // AddDescription
            // 
            AddDescription.Location = new Point(77, 84);
            AddDescription.Name = "AddDescription";
            AddDescription.Size = new Size(135, 23);
            AddDescription.TabIndex = 5;
            // 
            // CatalogueDescription
            // 
            CatalogueDescription.AutoSize = true;
            CatalogueDescription.Location = new Point(4, 92);
            CatalogueDescription.Name = "CatalogueDescription";
            CatalogueDescription.Size = new Size(67, 15);
            CatalogueDescription.TabIndex = 4;
            CatalogueDescription.Text = "Description";
            // 
            // AddYear
            // 
            AddYear.Location = new Point(77, 198);
            AddYear.Name = "AddYear";
            AddYear.Size = new Size(135, 23);
            AddYear.TabIndex = 11;
            // 
            // CatalogueYear
            // 
            CatalogueYear.AutoSize = true;
            CatalogueYear.Location = new Point(42, 206);
            CatalogueYear.Name = "CatalogueYear";
            CatalogueYear.Size = new Size(29, 15);
            CatalogueYear.TabIndex = 10;
            CatalogueYear.Text = "Year";
            // 
            // AddType
            // 
            AddType.Location = new Point(77, 160);
            AddType.Name = "AddType";
            AddType.Size = new Size(135, 23);
            AddType.TabIndex = 9;
            // 
            // CatalogueType
            // 
            CatalogueType.AutoSize = true;
            CatalogueType.Location = new Point(40, 168);
            CatalogueType.Name = "CatalogueType";
            CatalogueType.Size = new Size(31, 15);
            CatalogueType.TabIndex = 8;
            CatalogueType.Text = "Type";
            // 
            // btnCatalogueAdd
            // 
            btnCatalogueAdd.Location = new Point(12, 234);
            btnCatalogueAdd.Name = "btnCatalogueAdd";
            btnCatalogueAdd.Size = new Size(107, 37);
            btnCatalogueAdd.TabIndex = 12;
            btnCatalogueAdd.Text = "Add";
            btnCatalogueAdd.UseVisualStyleBackColor = true;
            btnCatalogueAdd.Click += btnCatalogueAdd_Click;
            // 
            // btnCatalogueCancel
            // 
            btnCatalogueCancel.Location = new Point(132, 234);
            btnCatalogueCancel.Name = "btnCatalogueCancel";
            btnCatalogueCancel.Size = new Size(107, 37);
            btnCatalogueCancel.TabIndex = 13;
            btnCatalogueCancel.Text = "Cancel";
            btnCatalogueCancel.UseVisualStyleBackColor = true;
            btnCatalogueCancel.Click += btnCatalogueCancel_Click;
            // 
            // CatalogueItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(251, 283);
            Controls.Add(btnCatalogueCancel);
            Controls.Add(btnCatalogueAdd);
            Controls.Add(AddYear);
            Controls.Add(CatalogueYear);
            Controls.Add(AddType);
            Controls.Add(CatalogueType);
            Controls.Add(AddISBN);
            Controls.Add(CatalogueIsbn);
            Controls.Add(AddDescription);
            Controls.Add(CatalogueDescription);
            Controls.Add(AddAuthor);
            Controls.Add(CatalogueAuthor);
            Controls.Add(AddTitle);
            Controls.Add(CatalogueTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CatalogueItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CatalogueItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CatalogueTitle;
        private TextBox AddTitle;
        private TextBox AddAuthor;
        private Label CatalogueAuthor;
        private TextBox AddISBN;
        private Label CatalogueIsbn;
        private TextBox AddDescription;
        private Label CatalogueDescription;
        private TextBox AddYear;
        private Label CatalogueYear;
        private TextBox AddType;
        private Label CatalogueType;
        private Button btnCatalogueAdd;
        private Button btnCatalogueCancel;
    }
}