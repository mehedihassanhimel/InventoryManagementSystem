namespace InventoryManagementSystemProject
{
    partial class ProductManagement
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
            this.productPricetextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.productQuantitytextBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.productNametextBox = new System.Windows.Forms.TextBox();
            this.userNamelLabel = new System.Windows.Forms.Label();
            this.productIdtextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.productCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.editButtonProduct = new System.Windows.Forms.Button();
            this.homeButtonProduct = new System.Windows.Forms.Button();
            this.removeButtonProduct = new System.Windows.Forms.Button();
            this.addButtonProduc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productDetailstextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearProductbutton = new System.Windows.Forms.Button();
            this.selectCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.searchButtonbutton = new System.Windows.Forms.Button();
            this.ProBackbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Management";
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
            this.panel1.TabIndex = 3;
            // 
            // productPricetextBox
            // 
            this.productPricetextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPricetextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productPricetextBox.Location = new System.Drawing.Point(709, 136);
            this.productPricetextBox.Name = "productPricetextBox";
            this.productPricetextBox.Size = new System.Drawing.Size(220, 27);
            this.productPricetextBox.TabIndex = 19;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneLabel.Location = new System.Drawing.Point(706, 104);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(105, 18);
            this.phoneLabel.TabIndex = 18;
            this.phoneLabel.Text = "Product Price";
            // 
            // productQuantitytextBox
            // 
            this.productQuantitytextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantitytextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productQuantitytextBox.Location = new System.Drawing.Point(477, 136);
            this.productQuantitytextBox.Name = "productQuantitytextBox";
            this.productQuantitytextBox.Size = new System.Drawing.Size(220, 27);
            this.productQuantitytextBox.TabIndex = 17;
            this.productQuantitytextBox.TextChanged += new System.EventHandler(this.productQuantitytextBox_TextChanged);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userPasswordLabel.Location = new System.Drawing.Point(474, 104);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(127, 18);
            this.userPasswordLabel.TabIndex = 16;
            this.userPasswordLabel.Text = "Product Quantity";
            // 
            // productNametextBox
            // 
            this.productNametextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNametextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productNametextBox.Location = new System.Drawing.Point(246, 136);
            this.productNametextBox.Name = "productNametextBox";
            this.productNametextBox.Size = new System.Drawing.Size(220, 27);
            this.productNametextBox.TabIndex = 15;
            // 
            // userNamelLabel
            // 
            this.userNamelLabel.AutoSize = true;
            this.userNamelLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userNamelLabel.Location = new System.Drawing.Point(243, 104);
            this.userNamelLabel.Name = "userNamelLabel";
            this.userNamelLabel.Size = new System.Drawing.Size(108, 18);
            this.userNamelLabel.TabIndex = 14;
            this.userNamelLabel.Text = "Product Name";
            // 
            // productIdtextBox
            // 
            this.productIdtextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdtextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productIdtextBox.Location = new System.Drawing.Point(14, 136);
            this.productIdtextBox.Name = "productIdtextBox";
            this.productIdtextBox.Size = new System.Drawing.Size(220, 27);
            this.productIdtextBox.TabIndex = 13;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userIdLabel.Location = new System.Drawing.Point(10, 103);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(91, 19);
            this.userIdLabel.TabIndex = 12;
            this.userIdLabel.Text = "Product Id";
            // 
            // productCategorycomboBox
            // 
            this.productCategorycomboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategorycomboBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.productCategorycomboBox.FormattingEnabled = true;
            this.productCategorycomboBox.Location = new System.Drawing.Point(947, 180);
            this.productCategorycomboBox.Name = "productCategorycomboBox";
            this.productCategorycomboBox.Size = new System.Drawing.Size(220, 32);
            this.productCategorycomboBox.TabIndex = 20;
            this.productCategorycomboBox.Text = "Product Category";
            this.productCategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editButtonProduct
            // 
            this.editButtonProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButtonProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editButtonProduct.Location = new System.Drawing.Point(1038, 300);
            this.editButtonProduct.Name = "editButtonProduct";
            this.editButtonProduct.Size = new System.Drawing.Size(106, 30);
            this.editButtonProduct.TabIndex = 42;
            this.editButtonProduct.Text = "Edit";
            this.editButtonProduct.UseVisualStyleBackColor = true;
            this.editButtonProduct.Click += new System.EventHandler(this.editButtonProduct_Click);
            // 
            // homeButtonProduct
            // 
            this.homeButtonProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButtonProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.homeButtonProduct.Location = new System.Drawing.Point(1038, 336);
            this.homeButtonProduct.Name = "homeButtonProduct";
            this.homeButtonProduct.Size = new System.Drawing.Size(106, 30);
            this.homeButtonProduct.TabIndex = 41;
            this.homeButtonProduct.Text = "Home";
            this.homeButtonProduct.UseVisualStyleBackColor = true;
            // 
            // removeButtonProduct
            // 
            this.removeButtonProduct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButtonProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeButtonProduct.Location = new System.Drawing.Point(1038, 264);
            this.removeButtonProduct.Name = "removeButtonProduct";
            this.removeButtonProduct.Size = new System.Drawing.Size(106, 30);
            this.removeButtonProduct.TabIndex = 40;
            this.removeButtonProduct.Text = "Remove";
            this.removeButtonProduct.UseVisualStyleBackColor = true;
            this.removeButtonProduct.Click += new System.EventHandler(this.removeButtonProduct_Click);
            // 
            // addButtonProduc
            // 
            this.addButtonProduc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButtonProduc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addButtonProduc.Location = new System.Drawing.Point(1038, 228);
            this.addButtonProduc.Name = "addButtonProduc";
            this.addButtonProduc.Size = new System.Drawing.Size(106, 30);
            this.addButtonProduc.TabIndex = 39;
            this.addButtonProduc.Text = "Add";
            this.addButtonProduc.UseVisualStyleBackColor = true;
            this.addButtonProduc.Click += new System.EventHandler(this.addButtonProduc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(431, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "PRODUCT LIST ";
            // 
            // productDataGridView
            // 
            this.productDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.productDataGridView.GridColor = System.Drawing.Color.Black;
            this.productDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productDataGridView.Location = new System.Drawing.Point(85, 264);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(844, 397);
            this.productDataGridView.TabIndex = 44;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // productDetailstextBox
            // 
            this.productDetailstextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetailstextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productDetailstextBox.Location = new System.Drawing.Point(947, 136);
            this.productDetailstextBox.Name = "productDetailstextBox";
            this.productDetailstextBox.Size = new System.Drawing.Size(220, 27);
            this.productDetailstextBox.TabIndex = 46;
            this.productDetailstextBox.TextChanged += new System.EventHandler(this.producDetailstextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(944, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Product Details";
            // 
            // clearProductbutton
            // 
            this.clearProductbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearProductbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearProductbutton.Location = new System.Drawing.Point(477, 180);
            this.clearProductbutton.Name = "clearProductbutton";
            this.clearProductbutton.Size = new System.Drawing.Size(106, 30);
            this.clearProductbutton.TabIndex = 47;
            this.clearProductbutton.Text = "Clear";
            this.clearProductbutton.UseVisualStyleBackColor = true;
            this.clearProductbutton.Click += new System.EventHandler(this.clearProductbutton_Click);
            // 
            // selectCategorycomboBox
            // 
            this.selectCategorycomboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorycomboBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectCategorycomboBox.FormattingEnabled = true;
            this.selectCategorycomboBox.Location = new System.Drawing.Point(317, 667);
            this.selectCategorycomboBox.Name = "selectCategorycomboBox";
            this.selectCategorycomboBox.Size = new System.Drawing.Size(220, 32);
            this.selectCategorycomboBox.TabIndex = 48;
            this.selectCategorycomboBox.Text = "Select Category";
            this.selectCategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.selectPCategorycomboBox_SelectedIndexChanged);
            // 
            // searchButtonbutton
            // 
            this.searchButtonbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtonbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchButtonbutton.Location = new System.Drawing.Point(543, 667);
            this.searchButtonbutton.Name = "searchButtonbutton";
            this.searchButtonbutton.Size = new System.Drawing.Size(106, 32);
            this.searchButtonbutton.TabIndex = 49;
            this.searchButtonbutton.Text = "Search";
            this.searchButtonbutton.UseVisualStyleBackColor = true;
            this.searchButtonbutton.Click += new System.EventHandler(this.searchButtonbutton_Click);
            // 
            // ProBackbutton
            // 
            this.ProBackbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProBackbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProBackbutton.Location = new System.Drawing.Point(655, 669);
            this.ProBackbutton.Name = "ProBackbutton";
            this.ProBackbutton.Size = new System.Drawing.Size(106, 30);
            this.ProBackbutton.TabIndex = 50;
            this.ProBackbutton.Text = "Back";
            this.ProBackbutton.UseVisualStyleBackColor = true;
            this.ProBackbutton.Click += new System.EventHandler(this.ProBackbutton_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1186, 837);
            this.Controls.Add(this.ProBackbutton);
            this.Controls.Add(this.searchButtonbutton);
            this.Controls.Add(this.selectCategorycomboBox);
            this.Controls.Add(this.clearProductbutton);
            this.Controls.Add(this.productDetailstextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.editButtonProduct);
            this.Controls.Add(this.homeButtonProduct);
            this.Controls.Add(this.removeButtonProduct);
            this.Controls.Add(this.addButtonProduc);
            this.Controls.Add(this.productCategorycomboBox);
            this.Controls.Add(this.productPricetextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.productQuantitytextBox);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.productNametextBox);
            this.Controls.Add(this.userNamelLabel);
            this.Controls.Add(this.productIdtextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productPricetextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox productQuantitytextBox;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox productNametextBox;
        private System.Windows.Forms.Label userNamelLabel;
        private System.Windows.Forms.TextBox productIdtextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.ComboBox productCategorycomboBox;
        private System.Windows.Forms.Button editButtonProduct;
        private System.Windows.Forms.Button homeButtonProduct;
        private System.Windows.Forms.Button removeButtonProduct;
        private System.Windows.Forms.Button addButtonProduc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TextBox productDetailstextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearProductbutton;
        private System.Windows.Forms.ComboBox selectCategorycomboBox;
        private System.Windows.Forms.Button searchButtonbutton;
        private System.Windows.Forms.Button ProBackbutton;
    }
}