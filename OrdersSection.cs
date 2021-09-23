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
    public partial class OrdersSection : Form
    {
        public OrdersSection()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tafsir\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void OrderSellersDataView1()
        {
            try
            {
                con.Open();
                string myQuery = "select SellerId,SellerName,SellerPhone,SellerAddress from SellersTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                OrderSellerDataGridView1.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

     
        private void OrderSellerDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OSIdtextBox1.Text = OrderSellerDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            OSNametextBox1.Text = OrderSellerDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        void OrderSelectCategoryDataView1()
        {
            try
            {
                con.Open();
                string Query = "select * from ProductTable1";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(Query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                orderproductDataGridView1.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }

        void OrderSelectCategoryList1()
        {
            string myQuery = "select * from CategoryTable1";
            con.Open();
            SqlCommand cmd = new SqlCommand(myQuery, con);


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CategoryName", typeof(string));
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            orderselectCategorycomboBox1.ValueMember = "CategoryName";
            orderselectCategorycomboBox1.DataSource = dataTable;

            con.Close();

        }


        int serial = 0;
        string product;
        int quantity, price, totalPrice;

        private void OrdersSection_Load(object sender, EventArgs e)
        {
            OrderSellersDataView1();
            OrderSelectCategoryDataView1();
            OrderSelectCategoryList1();
        }

        void Update()
        {

            int idNo = Convert.ToInt32(orderproductDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //int inSell = Convert.ToInt32(productQuantitytextBox1.Text);
            //int availableStock = totalStock - inSell;
            int availableStock = totalStock - Convert.ToInt32(productQuantitytextBox1.Text);
            con.Open();
            string query = "update ProductTable1 set ProductQuantity=" + availableStock + "where ProductId=" + idNo + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            OrderSelectCategoryDataView1();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int flag = 0;
        int totalStock;
        private void orderproductDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = orderproductDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            totalStock = Convert.ToInt32(orderproductDataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            price = Convert.ToInt32(orderproductDataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            orderProducttextBox1.Text = orderproductDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            flag = 1;
        }

        int N = 0;

        private void addButton1_Click(object sender, EventArgs e)
        {
            //int sellQuantity = Convert.ToInt32(productQuantitytextBox1.Text);
            if (productQuantitytextBox1.Text == "")
            {
                MessageBox.Show("Enter Product Quantity First ");
            }
            else if (flag == 0)
            {
                MessageBox.Show(" Select Your Product First ");
            }
            else if (Convert.ToInt32(productQuantitytextBox1.Text) > totalStock)
            {
                MessageBox.Show("Product Out Of Stock");
            }
            else
            {
                serial = serial + 1;
                quantity = Convert.ToInt32(productQuantitytextBox1.Text);
                totalPrice = quantity * price;

                DataTable table = new DataTable();

                table.Columns.Add("Serial", typeof(Int32));
                table.Columns.Add("Product", typeof(string));
                table.Columns.Add("Quantity", typeof(Int32));
                table.Columns.Add("Price", typeof(Int32));
                table.Columns.Add("TotalPrice", typeof(Int32));
                //addOrderdataGridView1.Visible = true;
                table.Rows.Add(serial, product, quantity, price, totalPrice);
                addOrderdataGridView1.DataSource = table;

                flag = 0;
            }
            N = N + totalPrice;
            totalAmounttextBox1.Text = N.ToString();
            Update();
        }

        void OrderSearchCategoryList1()
        {

            try
            {
                con.Open();
                string myQuery = "select * from ProductTable1 where ProductCategory='" + orderselectCategorycomboBox1.SelectedValue.ToString() + "'";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                orderproductDataGridView1.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }


        }

        private void OrderSearchbutton1_Click(object sender, EventArgs e)
        {
            OrderSearchCategoryList1();
        }

        private void addOrderbutton1_Click(object sender, EventArgs e)
        {
            if (orderIdtextBox1.Text == "" || OSIdtextBox1.Text == "" || OSNametextBox1.Text == "" || totalAmounttextBox1.Text == "")
            {
                MessageBox.Show("Information Missing");
            }
            else
            {
                try
                {
                    con.Open();
                    //string query = "insert into OTable2 values(" + orderIdtextBox1.Text + "," + OSIdtextBox1.Text + ",'" + OSNametextBox1.Text + "','" + orderdateTime1.Value + "','" + totalAmounttextBox1.Text +"',"+ orderProducttextBox1.Text + ")";
                    string query = "insert into OTable2 values(" + orderIdtextBox1.Text + "," + OSIdtextBox1.Text + ",'" + OSNametextBox1.Text + "','" + orderdateTime1.Value + "'," + totalAmounttextBox1.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);                                                                                       //"'," + totalAmounttextBox1.Text + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Order Added Successfully ");
                    con.Close();




                }
                catch { }
            }
        }

        void ViewOrderDataView()
        {
            try
            {
                con.Open();
                string Query = "select * from OTable2";

                SqlDataAdapter DataAdapter = new SqlDataAdapter(Query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
                var dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                viewOrderdataGridView.DataSource = dataSet.Tables[0];
                con.Close();


            }
            catch { }
        }

        private void viewOrderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewOrderbutton1_Click(object sender, EventArgs e)
        {
            ViewOrderDataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SELLERSECTION section = new SELLERSECTION();
            section.Show();
        }

        private void elearbutton_Click(object sender, EventArgs e)
        {
            
            //viewOrderdataGridView.Rows.Clear();
            viewOrderdataGridView.DataSource = null;
            viewOrderdataGridView.Rows.Clear();
        }

    }
}
