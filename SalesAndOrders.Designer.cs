namespace InventoryManagementSystemProject
{
    partial class SalesAndOrders
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
            this.OrderSellerDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.orderselectCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.orderproductDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdtextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.OSIdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OSNametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderdateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.productQuantitytextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.OrderSearchbutton = new System.Windows.Forms.Button();
            this.addOrderdataGridView = new System.Windows.Forms.DataGridView();
            this.totalAmounttextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addOrderbutton = new System.Windows.Forms.Button();
            this.orderProducttextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSellerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderproductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1249, 3);
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
            this.label1.Location = new System.Drawing.Point(516, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales And Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 100);
            this.panel1.TabIndex = 4;
            // 
            // OrderSellerDataGridView
            // 
            this.OrderSellerDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderSellerDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrderSellerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSellerDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderSellerDataGridView.GridColor = System.Drawing.Color.Black;
            this.OrderSellerDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSellerDataGridView.Location = new System.Drawing.Point(696, 140);
            this.OrderSellerDataGridView.Name = "OrderSellerDataGridView";
            this.OrderSellerDataGridView.RowTemplate.Height = 24;
            this.OrderSellerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderSellerDataGridView.Size = new System.Drawing.Size(574, 265);
            this.OrderSellerDataGridView.TabIndex = 45;
            this.OrderSellerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderSellerDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(967, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sellers";
            // 
            // orderselectCategorycomboBox
            // 
            this.orderselectCategorycomboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderselectCategorycomboBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.orderselectCategorycomboBox.FormattingEnabled = true;
            this.orderselectCategorycomboBox.Location = new System.Drawing.Point(853, 420);
            this.orderselectCategorycomboBox.Name = "orderselectCategorycomboBox";
            this.orderselectCategorycomboBox.Size = new System.Drawing.Size(158, 32);
            this.orderselectCategorycomboBox.TabIndex = 50;
            this.orderselectCategorycomboBox.Text = "Select Category";
            // 
            // orderproductDataGridView
            // 
            this.orderproductDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderproductDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.orderproductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderproductDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderproductDataGridView.GridColor = System.Drawing.Color.Black;
            this.orderproductDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderproductDataGridView.Location = new System.Drawing.Point(562, 458);
            this.orderproductDataGridView.Name = "orderproductDataGridView";
            this.orderproductDataGridView.RowTemplate.Height = 24;
            this.orderproductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderproductDataGridView.Size = new System.Drawing.Size(708, 292);
            this.orderproductDataGridView.TabIndex = 49;
            this.orderproductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderproductDataGridView_CellContentClick);
            // 
            // orderIdtextBox
            // 
            this.orderIdtextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdtextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.orderIdtextBox.Location = new System.Drawing.Point(12, 140);
            this.orderIdtextBox.Name = "orderIdtextBox";
            this.orderIdtextBox.Size = new System.Drawing.Size(256, 27);
            this.orderIdtextBox.TabIndex = 52;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userIdLabel.Location = new System.Drawing.Point(8, 115);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(74, 19);
            this.userIdLabel.TabIndex = 51;
            this.userIdLabel.Text = "Order Id";
            // 
            // OSIdtextBox
            // 
            this.OSIdtextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSIdtextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.OSIdtextBox.Location = new System.Drawing.Point(12, 199);
            this.OSIdtextBox.Name = "OSIdtextBox";
            this.OSIdtextBox.Size = new System.Drawing.Size(256, 27);
            this.OSIdtextBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(8, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Seller Id";
            // 
            // OSNametextBox
            // 
            this.OSNametextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSNametextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.OSNametextBox.Location = new System.Drawing.Point(12, 258);
            this.OSNametextBox.Name = "OSNametextBox";
            this.OSNametextBox.Size = new System.Drawing.Size(256, 27);
            this.OSNametextBox.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(8, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Seller Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(8, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Order Date";
            // 
            // orderdateTime
            // 
            this.orderdateTime.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.orderdateTime.Location = new System.Drawing.Point(12, 315);
            this.orderdateTime.Name = "orderdateTime";
            this.orderdateTime.Size = new System.Drawing.Size(256, 27);
            this.orderdateTime.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(985, 755);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 59;
            this.label6.Text = "Add Quantity";
            // 
            // productQuantitytextBox
            // 
            this.productQuantitytextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantitytextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productQuantitytextBox.Location = new System.Drawing.Point(985, 777);
            this.productQuantitytextBox.Name = "productQuantitytextBox";
            this.productQuantitytextBox.Size = new System.Drawing.Size(122, 27);
            this.productQuantitytextBox.TabIndex = 60;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Location = new System.Drawing.Point(840, 776);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 30);
            this.addButton.TabIndex = 61;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.categorySearchButton_Click);
            // 
            // OrderSearchbutton
            // 
            this.OrderSearchbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSearchbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OrderSearchbutton.Location = new System.Drawing.Point(1017, 420);
            this.OrderSearchbutton.Name = "OrderSearchbutton";
            this.OrderSearchbutton.Size = new System.Drawing.Size(106, 32);
            this.OrderSearchbutton.TabIndex = 62;
            this.OrderSearchbutton.Text = "Search";
            this.OrderSearchbutton.UseVisualStyleBackColor = true;
            this.OrderSearchbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addOrderdataGridView
            // 
            this.addOrderdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.addOrderdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.addOrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addOrderdataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.addOrderdataGridView.GridColor = System.Drawing.Color.Black;
            this.addOrderdataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addOrderdataGridView.Location = new System.Drawing.Point(12, 458);
            this.addOrderdataGridView.Name = "addOrderdataGridView";
            this.addOrderdataGridView.RowTemplate.Height = 24;
            this.addOrderdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addOrderdataGridView.Size = new System.Drawing.Size(544, 292);
            this.addOrderdataGridView.TabIndex = 63;
            this.addOrderdataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.addOrderdataGridView_RowPostPaint);
            // 
            // totalAmounttextBox
            // 
            this.totalAmounttextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmounttextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.totalAmounttextBox.Location = new System.Drawing.Point(137, 777);
            this.totalAmounttextBox.Name = "totalAmounttextBox";
            this.totalAmounttextBox.Size = new System.Drawing.Size(182, 27);
            this.totalAmounttextBox.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(8, 782);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Total Amount";
            // 
            // addOrderbutton
            // 
            this.addOrderbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addOrderbutton.Location = new System.Drawing.Point(274, 140);
            this.addOrderbutton.Name = "addOrderbutton";
            this.addOrderbutton.Size = new System.Drawing.Size(127, 30);
            this.addOrderbutton.TabIndex = 66;
            this.addOrderbutton.Text = "Add Order";
            this.addOrderbutton.UseVisualStyleBackColor = true;
            this.addOrderbutton.Click += new System.EventHandler(this.addOrderbutton_Click);
            // 
            // orderProducttextBox
            // 
            this.orderProducttextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProducttextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.orderProducttextBox.Location = new System.Drawing.Point(12, 378);
            this.orderProducttextBox.Name = "orderProducttextBox";
            this.orderProducttextBox.Size = new System.Drawing.Size(256, 27);
            this.orderProducttextBox.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(8, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 68;
            this.label8.Text = "Order Product";
            // 
            // SalesAndOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.orderProducttextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addOrderbutton);
            this.Controls.Add(this.totalAmounttextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addOrderdataGridView);
            this.Controls.Add(this.OrderSearchbutton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productQuantitytextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderdateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OSNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OSIdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderIdtextBox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.orderselectCategorycomboBox);
            this.Controls.Add(this.orderproductDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderSellerDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesAndOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesAndOrders";
            this.Load += new System.EventHandler(this.SalesAndOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSellerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderproductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrderSellerDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orderselectCategorycomboBox;
        private System.Windows.Forms.DataGridView orderproductDataGridView;
        private System.Windows.Forms.TextBox orderIdtextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox OSIdtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OSNametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker orderdateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productQuantitytextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button OrderSearchbutton;
        private System.Windows.Forms.DataGridView addOrderdataGridView;
        private System.Windows.Forms.TextBox totalAmounttextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addOrderbutton;
        private System.Windows.Forms.TextBox orderProducttextBox;
        private System.Windows.Forms.Label label8;
    }
}