namespace InventoryManagementSystemProject
{
    partial class CategoryManagement
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
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButtonCategory = new System.Windows.Forms.Button();
            this.homeButtonCaategory = new System.Windows.Forms.Button();
            this.editButtonCategory = new System.Windows.Forms.Button();
            this.removeButtonCategory = new System.Windows.Forms.Button();
            this.addButtonCategory = new System.Windows.Forms.Button();
            this.categoryDetailstextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.categoryNametextBox = new System.Windows.Forms.TextBox();
            this.userNamelLabel = new System.Windows.Forms.Label();
            this.categoryIdtextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.categorySearchButton = new System.Windows.Forms.Button();
            this.CatBackbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1154, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(29, 29);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(463, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 100);
            this.panel1.TabIndex = 2;
            // 
            // clearButtonCategory
            // 
            this.clearButtonCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButtonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearButtonCategory.Location = new System.Drawing.Point(622, 245);
            this.clearButtonCategory.Name = "clearButtonCategory";
            this.clearButtonCategory.Size = new System.Drawing.Size(87, 30);
            this.clearButtonCategory.TabIndex = 34;
            this.clearButtonCategory.Text = "Clear";
            this.clearButtonCategory.UseVisualStyleBackColor = true;
            this.clearButtonCategory.Click += new System.EventHandler(this.clearButtonCategory_Click);
            // 
            // homeButtonCaategory
            // 
            this.homeButtonCaategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButtonCaategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.homeButtonCaategory.Location = new System.Drawing.Point(529, 245);
            this.homeButtonCaategory.Name = "homeButtonCaategory";
            this.homeButtonCaategory.Size = new System.Drawing.Size(87, 32);
            this.homeButtonCaategory.TabIndex = 31;
            this.homeButtonCaategory.Text = "Home";
            this.homeButtonCaategory.UseVisualStyleBackColor = true;
            // 
            // editButtonCategory
            // 
            this.editButtonCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButtonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editButtonCategory.Location = new System.Drawing.Point(735, 213);
            this.editButtonCategory.Name = "editButtonCategory";
            this.editButtonCategory.Size = new System.Drawing.Size(106, 30);
            this.editButtonCategory.TabIndex = 29;
            this.editButtonCategory.Text = "Edit";
            this.editButtonCategory.UseVisualStyleBackColor = true;
            this.editButtonCategory.Click += new System.EventHandler(this.editButtonCategory_Click);
            // 
            // removeButtonCategory
            // 
            this.removeButtonCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButtonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeButtonCategory.Location = new System.Drawing.Point(735, 177);
            this.removeButtonCategory.Name = "removeButtonCategory";
            this.removeButtonCategory.Size = new System.Drawing.Size(106, 30);
            this.removeButtonCategory.TabIndex = 27;
            this.removeButtonCategory.Text = "Remove";
            this.removeButtonCategory.UseVisualStyleBackColor = true;
            this.removeButtonCategory.Click += new System.EventHandler(this.removeButtonCategory_Click);
            // 
            // addButtonCategory
            // 
            this.addButtonCategory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButtonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addButtonCategory.Location = new System.Drawing.Point(735, 141);
            this.addButtonCategory.Name = "addButtonCategory";
            this.addButtonCategory.Size = new System.Drawing.Size(106, 30);
            this.addButtonCategory.TabIndex = 25;
            this.addButtonCategory.Text = "Add";
            this.addButtonCategory.UseVisualStyleBackColor = true;
            this.addButtonCategory.Click += new System.EventHandler(this.addButtonCategory_Click);
            // 
            // categoryDetailstextBox
            // 
            this.categoryDetailstextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDetailstextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.categoryDetailstextBox.Location = new System.Drawing.Point(506, 210);
            this.categoryDetailstextBox.Name = "categoryDetailstextBox";
            this.categoryDetailstextBox.Size = new System.Drawing.Size(220, 27);
            this.categoryDetailstextBox.TabIndex = 33;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneLabel.Location = new System.Drawing.Point(329, 210);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(139, 19);
            this.phoneLabel.TabIndex = 32;
            this.phoneLabel.Text = "Category Details";
            // 
            // categoryNametextBox
            // 
            this.categoryNametextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNametextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.categoryNametextBox.Location = new System.Drawing.Point(506, 175);
            this.categoryNametextBox.Name = "categoryNametextBox";
            this.categoryNametextBox.Size = new System.Drawing.Size(220, 27);
            this.categoryNametextBox.TabIndex = 30;
            // 
            // userNamelLabel
            // 
            this.userNamelLabel.AutoSize = true;
            this.userNamelLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userNamelLabel.Location = new System.Drawing.Point(329, 175);
            this.userNamelLabel.Name = "userNamelLabel";
            this.userNamelLabel.Size = new System.Drawing.Size(130, 19);
            this.userNamelLabel.TabIndex = 28;
            this.userNamelLabel.Text = "Category Name";
            // 
            // categoryIdtextBox
            // 
            this.categoryIdtextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdtextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.categoryIdtextBox.Location = new System.Drawing.Point(506, 142);
            this.categoryIdtextBox.Name = "categoryIdtextBox";
            this.categoryIdtextBox.Size = new System.Drawing.Size(220, 27);
            this.categoryIdtextBox.TabIndex = 26;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userIdLabel.Location = new System.Drawing.Point(328, 142);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(100, 19);
            this.userIdLabel.TabIndex = 24;
            this.userIdLabel.Text = "Category Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(501, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "CATEGORIES LIST ";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryDataGridView.GridColor = System.Drawing.Color.Black;
            this.categoryDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoryDataGridView.Location = new System.Drawing.Point(373, 323);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowTemplate.Height = 24;
            this.categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGridView.Size = new System.Drawing.Size(468, 378);
            this.categoryDataGridView.TabIndex = 36;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick);
            // 
            // categorySearchButton
            // 
            this.categorySearchButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.categorySearchButton.Location = new System.Drawing.Point(735, 249);
            this.categorySearchButton.Name = "categorySearchButton";
            this.categorySearchButton.Size = new System.Drawing.Size(106, 30);
            this.categorySearchButton.TabIndex = 38;
            this.categorySearchButton.Text = "Search";
            this.categorySearchButton.UseVisualStyleBackColor = true;
            this.categorySearchButton.Click += new System.EventHandler(this.categorySearchButton_Click);
            // 
            // CatBackbutton
            // 
            this.CatBackbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatBackbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CatBackbutton.Location = new System.Drawing.Point(569, 707);
            this.CatBackbutton.Name = "CatBackbutton";
            this.CatBackbutton.Size = new System.Drawing.Size(106, 30);
            this.CatBackbutton.TabIndex = 39;
            this.CatBackbutton.Text = "Back";
            this.CatBackbutton.UseVisualStyleBackColor = true;
            this.CatBackbutton.Click += new System.EventHandler(this.CatBackbutton_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1186, 837);
            this.Controls.Add(this.CatBackbutton);
            this.Controls.Add(this.categorySearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.categoryNametextBox);
            this.Controls.Add(this.clearButtonCategory);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.homeButtonCaategory);
            this.Controls.Add(this.categoryIdtextBox);
            this.Controls.Add(this.editButtonCategory);
            this.Controls.Add(this.userNamelLabel);
            this.Controls.Add(this.removeButtonCategory);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addButtonCategory);
            this.Controls.Add(this.categoryDetailstextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryManagement";
            this.Text = "CategoryManagement";
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButtonCategory;
        private System.Windows.Forms.Button homeButtonCaategory;
        private System.Windows.Forms.Button editButtonCategory;
        private System.Windows.Forms.Button removeButtonCategory;
        private System.Windows.Forms.Button addButtonCategory;
        private System.Windows.Forms.TextBox categoryDetailstextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox categoryNametextBox;
        private System.Windows.Forms.Label userNamelLabel;
        private System.Windows.Forms.TextBox categoryIdtextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button categorySearchButton;
        private System.Windows.Forms.Button CatBackbutton;
    }
}