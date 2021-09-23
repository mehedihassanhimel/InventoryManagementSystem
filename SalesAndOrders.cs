using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemProject
{
    public partial class SalesAndOrders : Form
    {
        public SalesAndOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void OrderSellersDataView()
        {
            try
            {
                con.Open();
                string myQuery = "select SellerId,SellerName,SellerPhone,SellerAddress from SellersTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                OrderSellerDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }

        void OrderSelectCategoryDataView()
        {
            try
            {
                con.Open();
                string Query = "select * from ProductTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(Query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                orderproductDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }

        void OrderSelectCategoryList()
        {
            string myQuery = "select * from CategoryTable1";
            con.Open();
            SqlCommand cmd = new SqlCommand(myQuery, con);


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CategoryName", typeof(string));
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            orderselectCategorycomboBox.ValueMember = "CategoryName";
            orderselectCategorycomboBox.DataSource = dataTable;

            con.Close();

        }

        int serial = 0;
        //int serial;
        string product;
        int quantity, price, totalPrice;


        private void SalesAndOrders_Load(object sender, EventArgs e)
        {
            OrderSellersDataView();
            OrderSelectCategoryDataView();
            OrderSelectCategoryList();
        }

        void Update()
        {
            
            int idNo = Convert.ToInt32(orderproductDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            int inSell = Convert.ToInt32(productQuantitytextBox.Text);
            int availableStock = totalStock - inSell;
            con.Open();
            string query = "update ProductTable1 set ProductQuantity=" + availableStock + "where ProductId=" + idNo + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            OrderSelectCategoryDataView();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int flag = 0;
        int totalStock;
        private void orderproductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = orderproductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            totalStock = Convert.ToInt32(orderproductDataGridView.SelectedRows[0].Cells[2].Value.ToString());
            price = Convert.ToInt32(orderproductDataGridView.SelectedRows[0].Cells[3].Value.ToString());
            orderProducttextBox.Text = orderproductDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            
            flag = 1;
        }

        int N = 0;
        
        private void categorySearchButton_Click(object sender, EventArgs e)
        {
            int sellQuantity = Convert.ToInt32(productQuantitytextBox.Text);
            //int sellQuantity = Int32.Parse(this.productQuantitytextBox.Text);
            if(productQuantitytextBox.Text == "")
            {
                MessageBox.Show("Enter Product Quantity First ");
            }
            else if(flag == 0)
            {
                MessageBox.Show(" Select Your Product First ");
            }
            else if(sellQuantity > totalStock)
            {
                MessageBox.Show("Product Out Of Stock");
            }
            else
            {
                serial = serial + 1;
                quantity = Convert.ToInt32(productQuantitytextBox.Text);
                totalPrice = quantity * price;

                DataTable table = new DataTable();

                table.Columns.Add("Serial", typeof(Int32));
                table.Columns.Add("Product", typeof(string));
                table.Columns.Add("Quantity", typeof(Int32));
                table.Columns.Add("Price", typeof(Int32));
                table.Columns.Add("TotalPrice", typeof(Int32));
                addOrderdataGridView.Visible = true;
                table.Rows.Add(serial,product,quantity,price,totalPrice);
                addOrderdataGridView.DataSource = table;
              
                flag = 0;
            }
            N = N + totalPrice;
            totalAmounttextBox.Text = N.ToString();
            Update();
        }

        void OrderSearchCategoryList()
        {

            try
            {
                con.Open();
                string myQuery = "select * from ProductTable1 where ProductCategory='" + orderselectCategorycomboBox.SelectedValue.ToString() + "'";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                orderproductDataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderSearchCategoryList();
        }

       

        private void addOrderbutton_Click(object sender, EventArgs e)
        {
            if(orderIdtextBox.Text == "" || OSIdtextBox.Text == "" || OSNametextBox.Text == "" || totalAmounttextBox.Text == "" )
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into OTable1 values(" + orderIdtextBox.Text + "," + OSIdtextBox.Text + ",'" + OSNametextBox.Text + "','" + orderdateTime.Value + "'," + totalAmounttextBox.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Order Added Successfully ");
                    con.Close();
                    
                    


                }
                catch { }
            }
        }

        private void OrderSellerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OSIdtextBox.Text = OrderSellerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            OSNametextBox.Text = OrderSellerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void addOrderdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.addOrderdataGridView.Rows[e.RowIndex].Cells["Serial"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
