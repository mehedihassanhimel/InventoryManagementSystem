namespace InventoryManagementSystemProject
{
    partial class OrdersSection
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.addOrderbutton1 = new System.Windows.Forms.Button();
            this.totalAmounttextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton1 = new System.Windows.Forms.Button();
            this.productQuantitytextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.orderdateTime1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.OSNametextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OSIdtextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderIdtextBox1 = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.addOrderdataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderSearchbutton1 = new System.Windows.Forms.Button();
            this.orderselectCategorycomboBox1 = new System.Windows.Forms.ComboBox();
            this.orderproductDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderSellerDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewOrderdataGridView = new System.Windows.Forms.DataGridView();
            this.viewOrderbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.elearbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.orderProducttextBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderproductDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSellerDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1378, 3);
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
            this.label1.Location = new System.Drawing.Point(587, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders Section";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 76);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1388, 723);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.orderProducttextBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addOrderbutton1);
            this.tabPage1.Controls.Add(this.totalAmounttextBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.addButton1);
            this.tabPage1.Controls.Add(this.productQuantitytextBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.orderdateTime1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.OSNametextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.OSIdtextBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.orderIdtextBox1);
            this.tabPage1.Controls.Add(this.userIdLabel);
            this.tabPage1.Controls.Add(this.addOrderdataGridView1);
            this.tabPage1.Controls.Add(this.OrderSearchbutton1);
            this.tabPage1.Controls.Add(this.orderselectCategorycomboBox1);
            this.tabPage1.Controls.Add(this.orderproductDataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.OrderSellerDataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Orders";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(777, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 86;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addOrderbutton1
            // 
            this.addOrderbutton1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addOrderbutton1.Location = new System.Drawing.Point(25, 278);
            this.addOrderbutton1.Name = "addOrderbutton1";
            this.addOrderbutton1.Size = new System.Drawing.Size(127, 30);
            this.addOrderbutton1.TabIndex = 85;
            this.addOrderbutton1.Text = "Add Order";
            this.addOrderbutton1.UseVisualStyleBackColor = true;
            this.addOrderbutton1.Click += new System.EventHandler(this.addOrderbutton1_Click);
            // 
            // totalAmounttextBox1
            // 
            this.totalAmounttextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmounttextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.totalAmounttextBox1.Location = new System.Drawing.Point(32, 652);
            this.totalAmounttextBox1.Name = "totalAmounttextBox1";
            this.totalAmounttextBox1.Size = new System.Drawing.Size(182, 27);
            this.totalAmounttextBox1.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(28, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 83;
            this.label7.Text = "Total Amount";
            // 
            // addButton1
            // 
            this.addButton1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addButton1.Location = new System.Drawing.Point(1099, 649);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(100, 30);
            this.addButton1.TabIndex = 82;
            this.addButton1.Text = "Add ";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // productQuantitytextBox1
            // 
            this.productQuantitytextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantitytextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.productQuantitytextBox1.Location = new System.Drawing.Point(943, 652);
            this.productQuantitytextBox1.Name = "productQuantitytextBox1";
            this.productQuantitytextBox1.Size = new System.Drawing.Size(122, 27);
            this.productQuantitytextBox1.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(939, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "Add Quantity";
            // 
            // orderdateTime1
            // 
            this.orderdateTime1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.orderdateTime1.Location = new System.Drawing.Point(25, 245);
            this.orderdateTime1.Name = "orderdateTime1";
            this.orderdateTime1.Size = new System.Drawing.Size(256, 27);
            this.orderdateTime1.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(21, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 78;
            this.label5.Text = "Order Date";
            // 
            // OSNametextBox1
            // 
            this.OSNametextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSNametextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.OSNametextBox1.Location = new System.Drawing.Point(25, 188);
            this.OSNametextBox1.Name = "OSNametextBox1";
            this.OSNametextBox1.Size = new System.Drawing.Size(256, 27);
            this.OSNametextBox1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Seller Name";
            // 
            // OSIdtextBox1
            // 
            this.OSIdtextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSIdtextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.OSIdtextBox1.Location = new System.Drawing.Point(25, 129);
            this.OSIdtextBox1.Name = "OSIdtextBox1";
            this.OSIdtextBox1.Size = new System.Drawing.Size(256, 27);
            this.OSIdtextBox1.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(21, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Seller Id";
            // 
            // orderIdtextBox1
            // 
            this.orderIdtextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdtextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.orderIdtextBox1.Location = new System.Drawing.Point(25, 70);
            this.orderIdtextBox1.Name = "orderIdtextBox1";
            this.orderIdtextBox1.Size = new System.Drawing.Size(256, 27);
            this.orderIdtextBox1.TabIndex = 73;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userIdLabel.Location = new System.Drawing.Point(21, 45);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(74, 19);
            this.userIdLabel.TabIndex = 72;
            this.userIdLabel.Text = "Order Id";
            // 
            // addOrderdataGridView1
            // 
            this.addOrderdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.addOrderdataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.addOrderdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addOrderdataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.addOrderdataGridView1.GridColor = System.Drawing.Color.Black;
            this.addOrderdataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addOrderdataGridView1.Location = new System.Drawing.Point(17, 336);
            this.addOrderdataGridView1.Name = "addOrderdataGridView1";
            this.addOrderdataGridView1.RowTemplate.Height = 24;
            this.addOrderdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addOrderdataGridView1.Size = new System.Drawing.Size(576, 292);
            this.addOrderdataGridView1.TabIndex = 71;
            // 
            // OrderSearchbutton1
            // 
            this.OrderSearchbutton1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSearchbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OrderSearchbutton1.Location = new System.Drawing.Point(1062, 298);
            this.OrderSearchbutton1.Name = "OrderSearchbutton1";
            this.OrderSearchbutton1.Size = new System.Drawing.Size(106, 32);
            this.OrderSearchbutton1.TabIndex = 70;
            this.OrderSearchbutton1.Text = "Search";
            this.OrderSearchbutton1.UseVisualStyleBackColor = true;
            this.OrderSearchbutton1.Click += new System.EventHandler(this.OrderSearchbutton1_Click);
            // 
            // orderselectCategorycomboBox1
            // 
            this.orderselectCategorycomboBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderselectCategorycomboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.orderselectCategorycomboBox1.FormattingEnabled = true;
            this.orderselectCategorycomboBox1.Location = new System.Drawing.Point(898, 298);
            this.orderselectCategorycomboBox1.Name = "orderselectCategorycomboBox1";
            this.orderselectCategorycomboBox1.Size = new System.Drawing.Size(158, 32);
            this.orderselectCategorycomboBox1.TabIndex = 69;
            this.orderselectCategorycomboBox1.Text = "Select Category";
            // 
            // orderproductDataGridView1
            // 
            this.orderproductDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderproductDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.orderproductDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderproductDataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderproductDataGridView1.GridColor = System.Drawing.Color.Black;
            this.orderproductDataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderproductDataGridView1.Location = new System.Drawing.Point(629, 336);
            this.orderproductDataGridView1.Name = "orderproductDataGridView1";
            this.orderproductDataGridView1.RowTemplate.Height = 24;
            this.orderproductDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderproductDataGridView1.Size = new System.Drawing.Size(727, 292);
            this.orderproductDataGridView1.TabIndex = 68;
            this.orderproductDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderproductDataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(574, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Sellers";
            // 
            // OrderSellerDataGridView1
            // 
            this.OrderSellerDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderSellerDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrderSellerDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderSellerDataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderSellerDataGridView1.GridColor = System.Drawing.Color.Black;
            this.OrderSellerDataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSellerDataGridView1.Location = new System.Drawing.Point(303, 43);
            this.OrderSellerDataGridView1.Name = "OrderSellerDataGridView1";
            this.OrderSellerDataGridView1.RowTemplate.Height = 24;
            this.OrderSellerDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderSellerDataGridView1.Size = new System.Drawing.Size(574, 265);
            this.OrderSellerDataGridView1.TabIndex = 66;
            this.OrderSellerDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderSellerDataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.removebutton);
            this.tabPage2.Controls.Add(this.elearbutton);
            this.tabPage2.Controls.Add(this.viewOrderdataGridView);
            this.tabPage2.Controls.Add(this.viewOrderbutton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Orders";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // viewOrderdataGridView
            // 
            this.viewOrderdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.viewOrderdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.viewOrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrderdataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewOrderdataGridView.GridColor = System.Drawing.Color.Black;
            this.viewOrderdataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewOrderdataGridView.Location = new System.Drawing.Point(305, 138);
            this.viewOrderdataGridView.Name = "viewOrderdataGridView";
            this.viewOrderdataGridView.RowTemplate.Height = 24;
            this.viewOrderdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewOrderdataGridView.Size = new System.Drawing.Size(760, 325);
            this.viewOrderdataGridView.TabIndex = 69;
            this.viewOrderdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOrderdataGridView_CellContentClick);
            // 
            // viewOrderbutton1
            // 
            this.viewOrderbutton1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewOrderbutton1.Location = new System.Drawing.Point(615, 469);
            this.viewOrderbutton1.Name = "viewOrderbutton1";
            this.viewOrderbutton1.Size = new System.Drawing.Size(127, 30);
            this.viewOrderbutton1.TabIndex = 68;
            this.viewOrderbutton1.Text = "View Order";
            this.viewOrderbutton1.UseVisualStyleBackColor = true;
            this.viewOrderbutton1.Click += new System.EventHandler(this.viewOrderbutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(1032, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 65;
            // 
            // elearbutton
            // 
            this.elearbutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elearbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.elearbutton.Location = new System.Drawing.Point(748, 469);
            this.elearbutton.Name = "elearbutton";
            this.elearbutton.Size = new System.Drawing.Size(127, 30);
            this.elearbutton.TabIndex = 70;
            this.elearbutton.Text = "Clear";
            this.elearbutton.UseVisualStyleBackColor = true;
            this.elearbutton.Click += new System.EventHandler(this.elearbutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removebutton.Location = new System.Drawing.Point(482, 469);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(127, 30);
            this.removebutton.TabIndex = 71;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = true;
            // 
            // orderProducttextBox1
            // 
            this.orderProducttextBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProducttextBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.orderProducttextBox1.Location = new System.Drawing.Point(236, 652);
            this.orderProducttextBox1.Name = "orderProducttextBox1";
            this.orderProducttextBox1.Size = new System.Drawing.Size(256, 27);
            this.orderProducttextBox1.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(232, 629);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 87;
            this.label9.Text = "Order Product";
            // 
            // OrdersSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1412, 853);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersSection";
            this.Load += new System.EventHandler(this.OrdersSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOrderdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderproductDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSellerDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrderSellerDataGridView1;
        private System.Windows.Forms.Button OrderSearchbutton1;
        private System.Windows.Forms.ComboBox orderselectCategorycomboBox1;
        private System.Windows.Forms.DataGridView orderproductDataGridView1;
        private System.Windows.Forms.DataGridView addOrderdataGridView1;
        private System.Windows.Forms.DateTimePicker orderdateTime1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OSNametextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OSIdtextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderIdtextBox1;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox totalAmounttextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.TextBox productQuantitytextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addOrderbutton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView viewOrderdataGridView;
        private System.Windows.Forms.Button viewOrderbutton1;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button elearbutton;
        private System.Windows.Forms.TextBox orderProducttextBox1;
        private System.Windows.Forms.Label label9;
    }
}